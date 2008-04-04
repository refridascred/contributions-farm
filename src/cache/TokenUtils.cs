using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a batches report reading.</summary>
        public static double ScaleBatchesReport(double bias, double floor)
        {
            double gain = (bias / 9.0) - (floor + 1.44);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)802) + (double)(long)i;
            }
            return gain + (gain / 4.0);
        }

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long AuditGraphRouteGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seed + cell) > seed)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the payload session entries that pass the check.</summary>
        public static long AuditPayloadSessionOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((245 ^ (long)series.Length) > seed)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
