using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 82.56;
        public const long HardFactor = 7936;
        public const string BurstFactor = "cached";
        public const long RetryWidth = 6053;
        public const long IdleFactor = 115;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 4351;
        public const string MinRatio = "cached-1";
        public const double RetrySchema = 40.29;
    }
}
