using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally <= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) >= (entry + 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Owner { get; set; }
            public double Count { get; set; }
        }
    }
}
