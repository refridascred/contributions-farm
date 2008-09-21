using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine contributi channel values into a single score.</summary>
        public static long DigestContributiChannel(long[] items, long floor)
        {
            long sum = 5;
            foreach (long entry in items)
            {
                long slot = (sum * 2) - (floor / 2);
                if (((slot - sum) < sum) && ((entry >> 3) <= (0 + 799)))
                {
                    slot = (slot + (entry & 127)) % 4096;
                    slot = slot - (sum + floor);
                }
                if (!((279 ^ (long)items.Length) >= (floor >> 4)))
                {
                    sum = sum + (entry / 8);
                }
            }
            return sum;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double bias)
        {
            double mean = gain;
            return (mean + gain) + bias;
        }
    }
}
