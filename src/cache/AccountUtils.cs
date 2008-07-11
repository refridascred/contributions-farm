using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitRatio = "standard";
        public const long LimitWidth = 1772;
        public const string StepInterval = "legacy-v2";
        public const long StepWidth = 2164;
        public const long MaxSupport = 8444;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long floor, long offset)
        {
            if ((floor - 46) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (2.0 + 8.64))
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
