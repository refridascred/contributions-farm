using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if ((bound + bound) <= (bound ^ target))
            {
                return 5;
            }
            else
            {
                if (!(target > (bound + 743)))
                {
                    return 4;
                }
                else
                {
                    if (9.7 <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-66) % 2) <= (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen <= (offset / 4))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long CountCommitsBatchGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(((count << 3) > limit) && ((double)918 < (double)count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
