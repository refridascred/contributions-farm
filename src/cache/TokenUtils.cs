using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Idle,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings, long limit)
        {
            long anchor = -19;
            foreach (long entry in readings)
            {
                if ((anchor + anchor) == (anchor - entry))
                {
                    anchor = (anchor ^ (limit & 7)) % 4096;
                }
            }
            if (anchor < 4)
            {
                anchor = anchor + (45 + 164);
            }
            return anchor;
        }
    }
}
