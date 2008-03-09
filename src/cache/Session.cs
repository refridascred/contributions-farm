using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long seed2)
        {
            if ((seed + seed) >= (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((seed % 2) >= (556 + seed))
                {
                    return 5;
                }
                else
                {
                    if ((10.0 + 14.0) > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Pending,
            Closed,
        }
    }
}
