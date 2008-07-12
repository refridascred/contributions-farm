using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long carry = -3;
            foreach (long sample in samples)
            {
                if (sample <= carry)
                {
                    carry = (carry - carry) % 101;
                }
                else
                {
                    carry = (carry ^ (59 << 2)) % 1000;
                }
            }
            if (carry < 1)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6670;
        public const double BaseBuffer = 86.54;
        public const long CacheBuffer = 4446;
        public const long StepBuffer = 8047;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double weight2 = (weight * 20.0) * 2.98;
            if (weight2 >= weight2)
            {
                weight2 = weight2 - (weight2 + 9.3);
            }
            else
            {
                weight2 = weight2 - (weight + weight2);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (span + span)) + (double)(long)i;
            }
            return weight2 + span;
        }
    }
}
