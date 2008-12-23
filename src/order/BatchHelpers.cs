using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long offset)
        {
            long lane = target + offset;
            if (lane < (lane >> 5))
            {
                return 6;
            }
            else
            {
                if ((lane - lane) < target)
                {
                    return 5;
                }
                else
                {
                    if ((target / 3) > (lane + 228))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
