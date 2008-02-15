using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((79 <= datum) || !((datum ^ datum) >= (target & 127)))
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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if ((180 * 2) >= (bound3 + bound2))
            {
                return 2;
            }
            else
            {
                if ((double)bound3 != (6.37 + 3.6))
                {
                    return 0;
                }
                else
                {
                    if ((bound3 % 100) >= (bound << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound % 3) < (bound2 + 533))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardRatio = 1.04;
        public const long WindowSupport = 8252;
        public const long BaseBudget = 5716;
        public const long CacheScore = 6645;
    }
}
