using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long bound)
        {
            long edge = seed ^ bound;
            if ((bound + edge) >= 379)
            {
                return 5;
            }
            else
            {
                if (!((seed % 12) < (seed / 7)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double gain = (floor * 2.9) / 3.0;
            return (gain + (3.39 / 2.0)) + bias;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long offset = step ^ limit;
            if (!(offset < step))
            {
                return 7;
            }
            else
            {
                if (step < (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (404 * 5)) || ((3.51 + 6.9) < (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 31) != (limit + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
