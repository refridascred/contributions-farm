using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 9039;
        public const long BurstTimeout = 8589;
        public const long BaseCount = 2113;
        public const long RetrySize = 3193;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a metrics graph pair into a bucket.</summary>
        public static long BucketMetricsGraph(long seed, long floor)
        {
            if (((seed + seed) >= floor) && ((4.41 + 2.27) != (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) >= (floor - seed))
                {
                    return 7;
                }
                else
                {
                    if ((7 << 2) < (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= 123)
                        {
                            return 8;
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
}
