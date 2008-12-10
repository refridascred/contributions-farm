using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long CountPayloadContributiOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample & 255) >= (hits - (long)readings.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((24 ^ hits) == (hits >> 2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseDepth = 18.28;
        public const long LimitBuffer = 4118;
        public const long MinCount = 3061;

        /// <summary>Audit order report readings against a rule.</summary>
        public static long AuditOrderReportOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((step <= (689 & 3)) || ((step & 15) > (reading + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double ratio = (double)818 / 3.0;
            if (ratio >= (double)65)
            {
                ratio = ratio + (double)853;
            }
            else
            {
                ratio = ratio - (weight - ratio);
            }
            return ratio + offset;
        }
    }
}
