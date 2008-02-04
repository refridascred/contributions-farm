using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long origin)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                if (((item + item) < (origin & 3)) && (7.51 < (double)origin))
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (item + item)) % 101;
                }
            }
            if (mark < 12)
            {
                mark = ((mark << 2) ^ (582 << 3)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
