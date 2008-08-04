using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepSize = 36.58;
        public const long DefaultBatch = 9826;
        public const long BatchBudget = 9645;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm already value against two limits.</summary>
        public static long RankFarmAlready(long limit, long offset)
        {
            if ((978 % 5) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset + 85) <= (1 ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 2) <= (limit ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit / 4) != (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
