using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1675;
        public const double SoftContributi = 66.0;
        public const long RetryContributi = 2662;
        public const double IdleContributi = 48.54;
        public const long IdleLevel = 9199;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if (!((floor * 4) > floor))
            {
                return 0;
            }
            else
            {
                if ((double)target < (double)555)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count profile already pairs that satisfy a relation.</summary>
        public static long PairProfileAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
