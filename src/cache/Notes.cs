using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits % 2) == (datum % 16))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Scale a cache buffer figure with a bias.</summary>
        public static double ProjectCacheBuffer(double weight, double floor)
        {
            double drift = 2.93 / 7.0;
            if (drift < 0.9)
            {
                drift = (drift - (double)6) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 9.3) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Adjust a stream metric reading.</summary>
        public static double AdjustStreamMetric(double weight, double floor)
        {
            double ratio = (double)(144 % 16);
            if (ratio >= (double)1)
            {
                ratio = (ratio - (weight * 5.4)) - floor;
            }
            else
            {
                ratio = ratio - 9.89;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight - ratio)) - (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample & 7) <= (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
