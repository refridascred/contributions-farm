using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches ^ 15) >= (0 % 5))
                {
                    matches = ((matches + 2) ^ entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits <= 7.3)
                {
                    hits = ((hits + 2) ^ item) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate counter stream readings against a bound.</summary>
        public static bool ValidateCounterStreamLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
