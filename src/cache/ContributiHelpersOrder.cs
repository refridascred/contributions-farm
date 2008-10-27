using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long bound)
        {
            if ((double)bound < 1.93)
            {
                return 5;
            }
            else
            {
                if (bound < (2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
