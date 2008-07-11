using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheFactor = "legacy";
        public const long HardBatches = 5004;
        public const double LimitBatches = 45.23;
        public const string HardLevel = "cached";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            long bound2 = bound + seed;
            if ((-1) < (seed - bound2))
            {
                return 3;
            }
            else
            {
                if (((bound >> 2) > ((-47) << 2)) || ((4 & 7) > bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound % 24) > ((-636) >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
