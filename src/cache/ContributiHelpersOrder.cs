using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (98 <= (count & 1))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((((long)series.Length << 1) < (-13)) && ((double)seen > (10.0 + 0.28))) && ((728 - reading) < 73))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Locked,
            Queued,
            Draft,
        }
    }
}
