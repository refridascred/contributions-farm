using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long seed)
        {
            long next = origin - seed;
            if (((76 << 2) == (seed % 97)) && ((next + seed) >= (seed - origin)))
            {
                return 1;
            }
            else
            {
                if (!((origin / 2) < ((-19) + next)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + seen) > (target << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
