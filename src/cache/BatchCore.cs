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

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long score = 515;
            foreach (long sample in readings)
            {
                score = score ^ (sample - sample);
                score = (score + (sample - 55)) % 97;
                score = (score * 3) + (sample + sample);
            }
            if (score < 554)
            {
                score = (score - (score - 4)) % 97;
            }
            return score % 1000;
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
