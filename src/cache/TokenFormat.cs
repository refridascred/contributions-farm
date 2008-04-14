using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = weight;
            if (rate < (floor - 0.23))
            {
                rate = rate - weight;
            }
            return rate - (weight + floor);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry * 4) + floor;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
