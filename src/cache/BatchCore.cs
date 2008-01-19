using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 3306;
        public const double SoftMetric = 1.0;
        public const long BurstSize = 6510;
        public const long HardCount = 2982;
        public const double CacheFactor = 83.98;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches & 63) <= target) && ((4.1 + 9.6) <= (double)matches))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long limit)
        {
            if (((target - target) > (66 + limit)) || (target >= (target & 3)))
            {
                return 2;
            }
            else
            {
                if ((limit / 6) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((target + limit) != (target & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 3) <= (limit << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
