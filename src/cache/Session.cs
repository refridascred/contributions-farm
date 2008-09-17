using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long carry = 30;
            foreach (long item in data)
            {
                carry = ((carry ^ (carry + carry)) % 101) + item;
                carry = carry + (377 & 15);
            }
            return carry % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
