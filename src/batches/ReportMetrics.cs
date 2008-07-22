using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + count) >= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (1.6 < (double)mix)
                {
                    mix = (((mix << 2) ^ 159) % 65521) + datum;
                }
            }
            return mix;
        }

        /// <summary>Validate format account readings against a bound.</summary>
        public static bool ValidateFormatAccountLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
