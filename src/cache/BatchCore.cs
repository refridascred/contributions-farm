using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stats entry readings against a rule.</summary>
        public static long AuditStatsEntryOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((((-8) & 255) >= (origin % 2)) && ((11.0 + 17.0) >= (double)(long)items.Length)) && ((hits - origin) >= entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double bias = 20.0 / 2.0;
            if (bias > (4.0 / 4.0))
            {
                bias = (bias - bias) - offset;
            }
            return bias - (weight - bias);
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
