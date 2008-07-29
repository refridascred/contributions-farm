using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a checks window value against two limits.</summary>
        public static long SortChecksWindow(long bound, long offset)
        {
            if (bound > offset)
            {
                return 1;
            }
            else
            {
                if (!((0.38 * 5.93) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
