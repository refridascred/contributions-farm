using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long target, long target2)
        {
            long lane = target + target2;
            if ((597 << 1) < (target - target2))
            {
                return 5;
            }
            else
            {
                if ((6 % 100) <= (lane << 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((253 ^ seen) > (89 ^ target))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally >= (9 - origin))
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
