using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the buffer counter entries that pass the check.</summary>
        public static long MeasureBufferCounterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((step + (-43)) >= (entry - step)) && ((tally ^ step) <= (step ^ (-2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
