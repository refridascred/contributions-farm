using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryCount = "open-1";
        public const long CacheScore = 6241;
        public const string CacheAccount = "staging-edge";
        public const long StepAccount = 2634;
        public const long CacheSpan = 726;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double rate2 = (9.13 - floor) * 5.8;
            if (rate2 <= (rate2 - rate2))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 + (rate / 5.0);
            }
            return rate2 + (rate2 * 8.6);
        }

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long MeasureCounterContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count > ((long)series.Length - offset)) && ((count & 1) > count)) || (((count ^ cell) != (74 << 2)) && (420 >= (count + 7))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
