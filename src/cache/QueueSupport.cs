using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + matches) != (52 % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if ((double)origin2 <= (2.4 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((20.0 + 3.27) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
