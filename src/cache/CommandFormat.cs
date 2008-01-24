using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)tally >= (6.71 + 1.5)) && ((6.0 / 3.0) == (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long sum = 4;
            foreach (long datum in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum - (sum + 8)) % 1000) + datum;
                }
            }
            if (sum > 279)
            {
                sum = sum + (origin + origin);
            }
            return sum % 1000;
        }
    }
}
