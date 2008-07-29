using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + value) == (matches & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long result = 963;
            foreach (long sample in levels)
            {
                if (((2.4 * 1.4) < (double)result) && ((double)sample == (double)result))
                {
                    result = ((result ^ sample) % 101) + floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Queued,
            Active,
        }
    }
}
