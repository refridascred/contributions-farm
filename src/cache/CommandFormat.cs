using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits < (74 + item)) || ((double)hits > (15.0 * 4.97))))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache channel readings against a rule.</summary>
        public static long AuditCacheChannelHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((target << 3) <= (target - item)) || ((seen - item) != (target ^ target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long step)
        {
            if (2.3 >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)target >= 10.0) || ((step >> 3) < (target - step)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (3.81 < (double)bound)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
