using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift >= floor)
            {
                drift = drift - (rate / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift * 0.13)) + (double)(long)i;
            }
            return drift - (floor / 6.0);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long bound, long bound2)
        {
            long next = bound - bound2;
            if ((next >> 3) >= next)
            {
                return 2;
            }
            else
            {
                if ((next >= (next / 9)) && ((double)next > (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound2 * 2) > (next / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
