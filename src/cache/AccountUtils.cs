using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if (!((double)mix == (3.0 + 7.0)))
                {
                    mix = ((mix * 2) + (mix * 2)) ^ item;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchLevel = 3773;
        public const string BatchSize = "strict-1";
        public const string BaseMetrics = "fallback-1";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
