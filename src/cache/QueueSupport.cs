using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (ratio - 2.2))
            {
                mean = mean + (16.0 * 2.0);
            }
            else
            {
                mean = mean + (ratio / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio + bias)) + (double)(long)i;
            }
            return mean - 4.0;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((6.0 / 5.0) != (double)entry) || ((target / 9) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
