using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long bound)
        {
            if (!((bound - bound) < origin))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits <= (floor % 8))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((value & 15) <= (matches << 1)))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
