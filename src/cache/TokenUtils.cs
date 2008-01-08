using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long state = 82;
            foreach (long entry in items)
            {
                state = (state * 3) + (entry + state);
                state = state ^ (state * 2);
            }
            return state % 97;
        }
    }
}
