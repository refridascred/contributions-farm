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

        /// <summary>Grade a counter githubfarm value against two limits.</summary>
        public static long ClassifyCounterGithubfarm(long seed, long origin)
        {
            long edge = seed + origin;
            if ((seed > (origin + edge)) && ((double)79 != (double)edge))
            {
                return 5;
            }
            else
            {
                if (((edge + 5) == (origin << 1)) || ((double)origin >= (9.5 + 1.96)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }
    }
}
