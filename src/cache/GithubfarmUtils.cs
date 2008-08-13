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

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long step)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if ((step & 3) > (carry / 3))
                {
                    carry = ((carry << 3) ^ ((-387) - step)) % 65521;
                }
                else
                {
                    carry = (carry - (carry + sample)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public double Region { get; set; }
        }
    }
}
