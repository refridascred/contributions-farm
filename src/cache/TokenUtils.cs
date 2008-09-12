using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long mark = 583;
            foreach (long item in series)
            {
                if ((2.64 / 9.0) > (double)item)
                {
                    mark = ((mark - (item << 2)) % 4096) - origin;
                }
                else
                {
                    mark = (mark - 46) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry >= (matches >> 2))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits checks pair into a bucket.</summary>
        public static long SortCommitsChecks(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((1.0 >= (6.0 - 6.9)) && ((9.7 * 1.0) != (double)limit))
            {
                return 5;
            }
            else
            {
                if ((limit * 3) <= (515 % 60))
                {
                    return 8;
                }
                else
                {
                    if ((19.0 * 4.0) < (double)edge)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
