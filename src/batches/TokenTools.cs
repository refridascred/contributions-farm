using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value % 8) >= (seen % 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (0.9 >= (double)tally)
                {
                    tally = ((tally + 3) + reading) + offset;
                }
            }
            return tally;
        }
    }
}
