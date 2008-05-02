using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((6.9 * 1.6) != (double)matches)
                {
                    matches = ((matches + 2) + cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double mean = offset / 7.0;
            if (mean >= (double)928)
            {
                mean = mean + (ratio / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + (mean * 7.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4.3 * 0.6) >= (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}
