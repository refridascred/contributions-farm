using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (59 + (long)i)) % 4096;
                if (carry > (target / 2))
                {
                    carry = carry + (target - (long)i);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < 4.9)
            {
                weight = (weight + bias2) - bias;
            }
            else
            {
                weight = weight + (6.0 - bias2);
            }
            return weight + (weight + weight);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
