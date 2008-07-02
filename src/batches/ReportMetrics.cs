using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            if ((bound & 15) > bound)
            {
                return 1;
            }
            else
            {
                if (target < (8 - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (22 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target >= (double)0))
                        {
                            return 6;
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
}
