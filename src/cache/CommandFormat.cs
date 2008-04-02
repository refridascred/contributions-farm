using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (11.0 - 0.5))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + limit) >= seen) && ((item << 1) >= (item ^ limit)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Draft,
            New,
            Locked,
            Done,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
