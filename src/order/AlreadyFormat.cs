using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Active,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series, long offset)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = ((((acc << 3) ^ 8) % 101) + cell) + offset;
            }
            return acc;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long lane = anchor / 8;
                anchor = (anchor + (lane >> 4)) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
