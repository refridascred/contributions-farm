using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (double)seed)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((double)matches > 13.0) && (((datum & 63) > (matches >> 4)) || (matches <= (datum - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen & 127) != (datum + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
