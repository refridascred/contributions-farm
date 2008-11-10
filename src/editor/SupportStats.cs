using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 4663;
        public const long MaxContext = 3717;
        public const double IdleSize = 15.89;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 144;
            foreach (long datum in values)
            {
                score = (score + (score << 2)) + datum;
            }
            if (score > 2)
            {
                score = score ^ (score % 64);
            }
            return score;
        }
    }
}
