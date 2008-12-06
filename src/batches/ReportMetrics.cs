using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result << 3) ^ (result % 10)) % 101) + (long)i2;
                    result = result - (offset - result);
                }
                if (((long)i == (result << 1)) && ((4.1 * 1.9) < 2.72))
                {
                    result = result - (offset ^ offset);
                }
                else
                {
                    result = result - (result - 211);
                }
                result = (result ^ (3 + (-1))) % 4096;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((164 / 4) != (value - value)) && !((double)seed > 2.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
