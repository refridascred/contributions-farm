using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((59 & 63) > datum) && ((target & 31) <= datum)) && (target >= (625 - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long CountBufferRecordOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.85 - 7.3) <= (double)reading)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
