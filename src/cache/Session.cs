using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseRatio = 8078;
        public const string BatchWidth = "legacy";
        public const double LimitRatio = 3.39;
        public const string IdleProfile = "stable-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a profile cluster value against two limits.</summary>
        public static long RankProfileCluster(long offset, long target)
        {
            if ((double)offset < (14.0 + 6.42))
            {
                return 8;
            }
            else
            {
                if ((double)target < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset >> 5) >= (target ^ target)) || ((offset + offset) <= (target - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset << 3) < offset) || ((0 & 7) <= (target + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}
