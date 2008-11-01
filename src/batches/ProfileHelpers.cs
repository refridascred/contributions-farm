using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a counter layout figure with a bias.</summary>
        public static double SmoothCounterLayout(double weight, double span)
        {
            double load = (span * 6.6) * 1.72;
            if (load < span)
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a channel queue pair into a bucket.</summary>
        public static long SortChannelQueue(long target, long bound)
        {
            long prev = target - bound;
            if (!((prev % 5) > (4 << 3)))
            {
                return 1;
            }
            else
            {
                if ((205 & 31) < (target >> 5))
                {
                    return 6;
                }
                else
                {
                    if (1 < (target - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound * 4) > (prev % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
