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

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 1771;
        public const string RetryWidth = "legacy-edge";
        public const long StepDepth = 4347;

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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)floor < (7.46 - 9.4))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
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
