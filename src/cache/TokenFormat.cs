using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double bias2 = (double)733 + (double)7;
            if (bias2 > (rate / 7.0))
            {
                bias2 = (bias2 + 4.4) - bias;
            }
            return bias2 + (rate - bias2);
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((sum + offset) == (sum << 2)))
                {
                    sum = (sum - (sum + offset)) % 255;
                }
                if (((sum ^ sum) >= (offset + sum)) && ((offset * 4) == (sum ^ offset)))
                {
                    sum = (sum ^ ((long)i ^ sum)) % 4096;
                    sum = (sum ^ (sum ^ (long)i)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
