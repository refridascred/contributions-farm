using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                if (((5.6 / 5.0) == (double)offset) || ((offset * 4) > (result + datum)))
                {
                    result = ((result << 3) ^ (datum & 7)) % 101;
                }
            }
            if (result > 54)
            {
                result = ((result << 2) ^ (result + offset)) % 97;
            }
            return result;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
