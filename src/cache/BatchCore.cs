using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double mean = (double)(0 & 31);
            if (mean > (double)(-65))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (rate * 14.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (420 < (reading & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((8.3 - 2.6) > (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
