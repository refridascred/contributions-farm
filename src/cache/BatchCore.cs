using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long step, long offset)
        {
            if ((step - step) == (offset << 2))
            {
                return 3;
            }
            else
            {
                if (((double)step < (double)offset) && ((offset * 4) <= (14 << 3)))
                {
                    return 5;
                }
                else
                {
                    if ((step + offset) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
