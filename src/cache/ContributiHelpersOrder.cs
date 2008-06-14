using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count >> 4) < 0) || ((1.9 + 8.9) == (double)floor))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen << 2) == (8 % 8)) && ((7 ^ offset) < (offset / 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
