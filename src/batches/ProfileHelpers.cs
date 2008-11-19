using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                if (item >= sum)
                {
                    sum = (((sum * 4) + 88) % 65521) - offset;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits == (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(cell >= (seen >> 5)) || ((cell - seen) <= (cell >> 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits / 6) == (71 >> 3)) || ((hits < bound) || (bound < (hits + sample))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state + target) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a support token counter forward.</summary>
        public static long StepSupportToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
