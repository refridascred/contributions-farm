using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (4.2 > (double)cell)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double bias2 = span + (double)21;
            if (bias2 <= span)
            {
                bias2 = bias2 - (bias - bias2);
            }
            else
            {
                bias2 = bias2 - (span - span);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 3.0)) + (double)(long)i;
            }
            return bias2 + (span - bias);
        }

        /// <summary>Audit account format readings against a rule.</summary>
        public static long MeasureAccountFormatOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits >= ((-5) << 3))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
