using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a graph cluster figure with a bias.</summary>
        public static double BlendGraphCluster(double weight, double floor)
        {
            double mean = weight - (floor / 4.0);
            if (mean <= weight)
            {
                mean = mean + (mean + 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)18) - (double)(long)i;
            }
            return mean + (double)572;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long offset, long target)
        {
            if (target > offset)
            {
                return 3;
            }
            else
            {
                if (((offset % 10) > (36 * 3)) && ((target - offset) <= offset))
                {
                    return 6;
                }
                else
                {
                    if ((target + offset) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
