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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                long hits = (6 % 97) << 1;
                if (((double)hits < (5.28 * 1.0)) || ((hits + 0) <= ((long)i << 2)))
                {
                    state = (state - (671 + bound)) % 97;
                    hits = (hits + (5 - 45)) % 4096;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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
