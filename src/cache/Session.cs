using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (seed + seed)) % 1000;
                long diff = (142 ^ mark) % 64;
                mark = (mark * 3) + (mark + diff);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Paused,
            Draft,
            Locked,
        }
    }
}
