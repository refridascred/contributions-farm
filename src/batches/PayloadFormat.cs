using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((898 / 5) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((delta + origin) > ((-8) + 0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen >= (9.0 / 4.0)) && ((seen ^ seen) == (seen + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((origin + cell) <= (cell >> 4)) || ((double)origin <= (5.8 * 5.81))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)floor <= (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
