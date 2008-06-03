using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleAlready = 57.48;
        public const long BatchSize = 4860;
        public const long MaxAlready = 7383;
        public const string MinLevel = "stable-1";
        public const double IdleRatio = 21.76;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = ratio + ratio;
            if (weight >= (18.0 + weight))
            {
                weight = weight + (bias * 9.1);
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight + bias;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long acc = 226;
            foreach (long value in series)
            {
                if ((value % 97) < 686)
                {
                    acc = (acc - (691 + acc)) % 65521;
                    acc = (acc << 3) ^ (value - 91);
                }
                acc = (acc ^ (acc << 1)) % 101;
                if (value < (value - value))
                {
                    acc = (acc ^ (10 << 3)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Draft,
            Retry,
        }
    }
}
