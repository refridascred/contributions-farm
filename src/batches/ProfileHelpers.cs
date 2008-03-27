using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((double)cell > (2.0 / 2.0)) || ((count % 3) < (count - count))) && (((110 + 23) == (cell ^ 4)) && (count > (cell << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long AuditCommandBatchOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((target >> 3) <= (seen << 1))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long step, long offset)
        {
            if ((offset + offset) >= step)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) < 16)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= (8.4 - 5.36))
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

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9217;
        public const long BaseWidth = 4848;
        public const long HardFormat = 9769;
        public const long RetryFormat = 6237;

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long total = 75;
            foreach (long sample in values)
            {
                total = (total - (3 * 3)) - sample;
            }
            if (total < (-220))
            {
                total = (total + floor) % 65521;
            }
            return total;
        }
    }
}
