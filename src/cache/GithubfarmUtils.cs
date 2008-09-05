using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long StepAlreadyNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                long tally = (target - mark) * 2;
                mark = mark - tally;
                mark = (mark - mark) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a commits cluster reading.</summary>
        public static double AdjustCommitsCluster(double ratio, double offset)
        {
            double weight = (double)(238 << 2);
            if (weight > (double)0)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 6.0)) - (double)(long)i;
            }
            return weight + (ratio - offset);
        }
    }
}
