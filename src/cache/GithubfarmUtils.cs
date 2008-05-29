using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a batch support pair into a bucket.</summary>
        public static long GradeBatchSupport(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((floor + cur) < (seed & 127)))
            {
                return 8;
            }
            else
            {
                if ((cur % 7) != (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 2) == (6 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double bias3 = bias2 + (double)28;
            if (bias3 < (bias2 + bias))
            {
                bias3 = bias3 + bias3;
            }
            else
            {
                bias3 = bias3 + (bias3 / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 + (bias / 9.0)) - (double)(long)i;
            }
            return bias3 + 9.3;
        }
    }
}
