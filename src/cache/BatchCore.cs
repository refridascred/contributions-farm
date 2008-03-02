using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Idle,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long AuditCommitsFarmOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((seed + value) == (seed & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter contributi figure with a bias.</summary>
        public static double ScaleCounterContributi(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (double)479)
            {
                drift = (drift + (scale / 7.0)) + offset;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            return drift - (3.8 * 0.26);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + seen) < (950 + value))
                {
                    seen = seen + 2;
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
