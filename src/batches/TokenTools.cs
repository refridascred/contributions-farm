using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)value <= (1.07 - 3.9)) || ((20 << 2) <= ((-58) ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
