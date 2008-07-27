using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowBudget = 6915;
        public const long HardCommand = 9417;
        public const double BatchDepth = 92.51;

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long floor)
        {
            long mix = 655;
            foreach (long datum in data)
            {
                if ((datum - 1) == (datum - floor))
                {
                    mix = (mix << 2) ^ (343 + floor);
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "alpha-edge";
        public const long LimitWidth = 5593;
        public const long DefaultContext = 6362;
        public const long MinContext = 4238;
        public const long HardWidth = 503;

        /// <summary>Project the next graph account value.</summary>
        public static double ScaleGraphAccount(double weight, double offset)
        {
            double load = offset;
            return load - weight;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 - (bias + 18.0)) + rate;
        }
    }
}
