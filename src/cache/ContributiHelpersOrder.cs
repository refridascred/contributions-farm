using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster batches readings against a bound.</summary>
        public static bool ValidateClusterBatchesLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                acc = acc - ((long)samples.Length << 1);
                acc = acc ^ (8 + datum);
                if ((double)datum <= 6.0)
                {
                    acc = acc + (850 + datum);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
