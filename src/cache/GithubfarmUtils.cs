using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double bias)
        {
            double scale = (double)47 / 3.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + bias) + (double)(long)i) + weight;
            }
            return scale - (6.73 * 14.0);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (!((floor - 893) > (target + floor)))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) > floor)
                {
                    return 1;
                }
                else
                {
                    if ((target + floor) < (-2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((21 - floor) >= target)
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
