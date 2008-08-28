using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((mark << 1) != (origin << 1)))
                {
                    mark = mark - (origin % 24);
                }
                long lane = (long)i;
                if ((lane - origin) > (mark & 127))
                {
                    mark = ((mark << 2) ^ (9 + (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long CombineMetricAccount(long[] series)
        {
            long anchor = 83;
            foreach (long entry in series)
            {
                if (((anchor + anchor) != (anchor - anchor)) && ((348 * 5) <= (anchor + anchor)))
                {
                    anchor = (anchor + (entry & 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor ^ 59)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long AuditFilterStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - entry) != (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((48 > (carry - 80)) && ((carry - 481) <= carry))
                {
                    carry = ((carry * 3) + (origin & 7)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
