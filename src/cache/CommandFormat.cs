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
        public static bool ValidateChecksLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long AuditOrderLayoutOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (55 > (floor ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
