using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) >= tally)
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double bias)
        {
            double ratio2 = ratio;
            return ratio2 - (bias + ratio);
        }
    }
}
