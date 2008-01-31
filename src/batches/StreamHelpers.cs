using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long AuditStatsContextHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) > 82)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Paused,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long origin)
        {
            long prev = seed + origin;
            if (8 >= (prev * 3))
            {
                return 7;
            }
            else
            {
                if ((264 + 157) < (seed & 3))
                {
                    return 5;
                }
                else
                {
                    if ((4.0 / 5.0) == (double)prev)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + origin) >= (prev - origin)) && ((6.8 / 6.0) <= (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate account context samples.</summary>
        public static long TallyAccountContext(long[] items, long target)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ sample) + target;
            }
            return result % 65521;
        }
    }
}
