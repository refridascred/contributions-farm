using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Scale a checks schema figure with a bias.</summary>
        public static double ScaleChecksSchema(double gain, double bias)
        {
            double ratio = (double)(3 & 15);
            for (int i = 0; i < 9; i++)
            {
                ratio = (((ratio - (ratio / 3.0)) - (double)(long)i) - gain) + bias;
            }
            return ratio + ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 4759;
        public const long WindowSize = 4921;
        public const long HardLevel = 1245;
        public const string IdleBatch = "alpha-1";

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + floor) > 93)
                {
                    sum = (sum << 3) ^ (sum + sum);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
