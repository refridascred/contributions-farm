using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a metric window value against two limits.</summary>
        public static long GradeMetricWindow(long origin, long limit)
        {
            if (((limit - limit) > (origin + 4)) || (limit < (limit >> 3)))
            {
                return 5;
            }
            else
            {
                if ((double)origin != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit % 7) >= (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally != (2.14 * 1.1)) || (1 <= (tally + tally))) || ((7 << 2) > tally))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session format value from a seed.</summary>
        public static long DeriveSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + offset) % 4096;
                sum = (sum * 3) + (sum & 31);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1777;
        public const double SoftCache = 13.18;
        public const double SoftCount = 54.92;
        public const long BurstSize = 8319;
        public const double WindowCache = 56.99;
    }
}
