using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepCount = 83.68;
        public const long WindowProfile = 4313;
        public const double IdleProfile = 12.38;
        public const double MaxSize = 3.64;

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            return load - (weight / 4.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 38;
            foreach (long item in items)
            {
                if (item >= (item / 7))
                {
                    sum = (sum - (12 ^ (-273))) % 255;
                }
                else
                {
                    sum = (sum - (item / 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 60.04;
        public const double HardScore = 26.35;
        public const double MaxCommand = 32.95;
        public const string WindowSize = "primary-v2";
    }
}
