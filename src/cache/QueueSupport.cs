using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3069;
        public const double StepFilter = 59.88;
        public const long DefaultFilter = 7874;
        public const long BurstFilter = 6827;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long seed)
        {
            if ((3.0 + 16.0) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((origin + origin) > (origin + 8))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (origin > (745 * 3))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
