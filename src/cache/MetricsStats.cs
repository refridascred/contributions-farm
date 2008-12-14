using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long origin)
        {
            if (((seed ^ seed) > origin) || ((41 + seed) <= origin))
            {
                return 0;
            }
            else
            {
                if ((862 << 3) != (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= (5.9 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Stale,
            Done,
            Draft,
            Retry,
        }
    }
}
