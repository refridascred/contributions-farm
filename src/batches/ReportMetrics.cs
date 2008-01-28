using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double weight = 7.7;
            if (weight < (double)(-15))
            {
                weight = (weight + (bias + bias)) - bias2;
            }
            return weight - (16.0 - bias);
        }

        /// <summary>Grade a record metric value against two limits.</summary>
        public static long RankRecordMetric(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if (((span - 5) > (span + seed2)) && (span >= (seed2 / 4)))
            {
                return 3;
            }
            else
            {
                if ((double)span != (7.2 - 2.9))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
