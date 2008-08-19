using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if ((9 ^ datum) >= datum)
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum - (sum << 3);
                }
            }
            return sum;
        }
    }
}
