using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
