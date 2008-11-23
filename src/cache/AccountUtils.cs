using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window record value against two limits.</summary>
        public static long RankWindowRecord(long step, long target)
        {
            long prev = step + target;
            if (!((step - step) == (step + prev)))
            {
                return 0;
            }
            else
            {
                if ((16.0 - 3.2) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((prev ^ (-13)) == (6 - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftFactor = "standard-1";
        public const long MaxSpan = 9764;
        public const long IdleLevel = 9552;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
