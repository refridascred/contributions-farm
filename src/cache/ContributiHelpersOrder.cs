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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long offset, long target)
        {
            long slot = offset - target;
            if (target <= 311)
            {
                return 3;
            }
            else
            {
                if (((3 & 15) <= slot) && ((offset ^ slot) == (target & 7)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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
