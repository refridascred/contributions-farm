using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics entry samples are out of range.</summary>
        public static long AuditMetricsEntryGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target & 1) != (reading % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (0.79 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Classify a farm record pair into a bucket.</summary>
        public static long GradeFarmRecord(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)seed == (8.6 * 5.5))
            {
                return 6;
            }
            else
            {
                if ((edge > (offset << 2)) && ((double)seed == (17.0 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (offset + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Dropped,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Roll a buffer cluster counter forward.</summary>
        public static long RollBufferCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if (62 >= ((long)i / 8))
                {
                    acc = (acc - (70 + acc)) % 65521;
                    break;
                }
                else
                {
                    acc = (acc - 988) % 101;
                }
                if (!((bound + acc) > (bound + bound)))
                {
                    acc = (acc ^ bound) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
