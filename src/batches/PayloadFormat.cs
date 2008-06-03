using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(bound < (acc & 31)))
                {
                    acc = ((acc * 4) + (acc >> 5)) % 97;
                }
                acc = acc ^ ((long)i % 12);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

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
