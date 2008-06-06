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

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
