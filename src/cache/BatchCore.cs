using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((origin + reading) < (reading << 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double bias = ratio;
            return (bias + 4.8) + floor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)bound == (0.07 - 9.9)) && ((bound + bound) >= (16 - 372)))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long MeasureToolsSessionGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen & 1) != (reading ^ origin)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
