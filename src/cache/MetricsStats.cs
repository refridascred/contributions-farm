using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean - (mean - 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)9) - (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Check that every report format entry stays within the limit.</summary>
        public static bool VerifyReportFormatLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)entry <= (19.0 - 3.93)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double bias = (offset / 7.0) - (rate * 3.62);
            if (bias >= offset)
            {
                bias = bias + (8.85 / 3.0);
            }
            return bias + 3.7;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long CountSupportStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((11.0 - 7.57) != (double)hits) || ((datum - hits) >= 52))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
