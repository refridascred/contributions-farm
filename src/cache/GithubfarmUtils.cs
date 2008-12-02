using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long offset)
        {
            if ((offset - 17) <= seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((9.3 + 9.95) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset / 3) >= (6 + seed)) && ((seed / 4) > (seed - 45)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 43.8;
        public const double LimitCount = 24.14;
        public const long HardSpan = 265;
        public const string MaxInterval = "open-v2";

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double drift = (rate - rate) * 9.01;
            return (drift + (8.9 - rate)) + floor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Queued,
            Paused,
        }
    }
}
