using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double mean = (double)(7 / 6);
            if (mean > mean)
            {
                mean = (mean + (bias * 5.8)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - 7.0;
        }

        /// <summary>Classify a buffer account pair into a bucket.</summary>
        public static long BucketBufferAccount(long origin, long seed)
        {
            if ((origin << 3) == (seed % 97))
            {
                return 2;
            }
            else
            {
                if ((origin - seed) <= seed)
                {
                    return 7;
                }
                else
                {
                    if (((93 - 6) < seed) && ((seed - origin) == (seed + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
