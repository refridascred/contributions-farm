using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if (((double)carry < (7.0 / 9.0)) || (((-48) + 49) < entry))
                {
                    carry = (carry + (entry * 4)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ entry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Synced,
            Retry,
        }
    }
}
