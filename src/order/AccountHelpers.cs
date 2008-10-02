using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)floor <= 2.67)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long seed)
        {
            if (((494 << 1) >= offset) || ((offset / 9) >= (8 - 6)))
            {
                return 1;
            }
            else
            {
                if (offset >= (offset & 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) <= (offset - 379))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed > (7.3 / 8.0)) || ((offset ^ offset) >= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
