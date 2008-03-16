using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long SortMetricsBatches(long offset, long bound)
        {
            long gap = offset ^ bound;
            if ((gap + 2) > (gap + (-8)))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset & 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)175 >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (5 < offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
