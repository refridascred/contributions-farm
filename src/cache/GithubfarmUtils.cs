using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long result = 877;
            foreach (long value in items)
            {
                result = ((result << 3) ^ value) % 1000;
            }
            if (result < 233)
            {
                result = (result + (359 + step)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long step)
        {
            if (bound > (step + bound))
            {
                return 2;
            }
            else
            {
                if ((4.5 - 8.62) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (5.14 + 15.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
