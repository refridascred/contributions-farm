using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "fallback-edge";
        public const long MaxSupport = 1156;
        public const double BaseRatio = 97.11;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long limit)
        {
            if ((4.3 / 8.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((limit << 2) < (target + target)) && (limit <= (target + limit)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit < 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((7.26 * 16.0) > (double)target) || ((limit >> 1) > (485 << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
