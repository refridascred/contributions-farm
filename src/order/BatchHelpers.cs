using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings)
        {
            long anchor = -938;
            foreach (long entry in readings)
            {
                if ((38 ^ entry) == (entry >> 3))
                {
                    anchor = (anchor + (anchor & 31)) % 101;
                }
            }
            if (anchor > 791)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Pending,
            Active,
            Synced,
            Paused,
        }
    }
}
