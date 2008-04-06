using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit metrics editor readings against a rule.</summary>
        public static long TallyMetricsEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((count & 7) <= count) && (count <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= (double)308)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
