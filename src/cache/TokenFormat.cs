using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long seed2)
        {
            if ((7.3 - 8.2) <= (double)seed)
            {
                return 4;
            }
            else
            {
                if (((seed2 + 625) > (seed2 % 16)) && ((seed ^ seed2) > (68 - seed)))
                {
                    return 3;
                }
                else
                {
                    if ((seed2 + seed) > (492 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((853 / 3) == (seed2 + seed2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
