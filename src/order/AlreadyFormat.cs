using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((sample + sample) < (488 % 2)) && ((sample << 1) <= (82 * 5))) && (count >= (count - sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Pending,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Validate filter support readings against a bound.</summary>
        public static bool VerifyFilterSupportLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long floor)
        {
            if ((double)floor != (0.81 * 8.0))
            {
                return 8;
            }
            else
            {
                if (17.0 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double gain = span;
            if (gain < 6.2)
            {
                gain = (gain - (span / 4.0)) + rate;
            }
            return gain - span;
        }
    }
}
