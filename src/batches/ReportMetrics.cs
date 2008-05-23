using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (bound > tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
