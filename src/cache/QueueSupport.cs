using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            if ((double)origin <= (double)target)
            {
                return 0;
            }
            else
            {
                if (((double)origin > (1.4 / 4.0)) || ((double)target >= (1.1 - 4.7)))
                {
                    return 7;
                }
                else
                {
                    if ((8.2 / 2.0) < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 7) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 6329;
        public const long RetryWindow = 9061;
        public const long BatchWindow = 9545;
        public const double LimitLevel = 36.87;
    }
}
