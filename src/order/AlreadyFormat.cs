using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (4 > (tally - cell))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheFactor = 51.25;
        public const string BasePayload = "latest-1";
        public const double DefaultCount = 62.59;

        /// <summary>Check that every tools report entry stays within the limit.</summary>
        public static bool CheckToolsReportLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double load = bias + (bias / 8.0);
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 2.0) - (double)(long)i) + ratio;
            }
            return load - (double)7;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((5.77 - 13.0) < (double)count) || ((count ^ count) < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
