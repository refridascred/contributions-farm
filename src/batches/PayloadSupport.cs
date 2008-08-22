using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
