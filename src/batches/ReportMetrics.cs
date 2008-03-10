using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of profile queue entries.</summary>
        public static long TotalProfileQueue(long[] readings, long step)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                if ((step >> 4) != (result % 3))
                {
                    result = ((result * 4) + 757) % 1000;
                }
                if ((reading & 63) <= (reading + step))
                {
                    result = (result ^ result) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((0.13 - 8.55) < (double)target) || ((5.8 * 9.76) < (double)target)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
