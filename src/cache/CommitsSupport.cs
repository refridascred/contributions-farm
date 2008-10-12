using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double mean = (double)(-637) / 6.0;
            if (mean < 5.2)
            {
                mean = (mean - (offset + 20.0)) + ratio;
            }
            else
            {
                mean = mean + 1.11;
            }
            return mean + mean;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) - (double)(long)i) - span;
            }
            return bias - ratio;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double bias = floor;
            if (bias > bias)
            {
                bias = bias + (floor / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (floor - scale)) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (floor - floor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks record readings against a rule.</summary>
        public static long MeasureChecksRecordHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches <= ((long)items.Length % 10))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }
    }
}
