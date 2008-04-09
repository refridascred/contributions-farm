using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (8.77 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if (bound <= (bound ^ 3))
            {
                return 4;
            }
            else
            {
                if (((0 & 255) != (bound * 3)) || ((floor << 2) != (bound + floor)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSize = 5675;
        public const long BurstCount = 8442;
        public const long RetryBudget = 7657;
        public const long MinFarm = 7666;
        public const long StepFarm = 5278;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long seed)
        {
            long result = 51;
            foreach (long cell in items)
            {
                result = ((((result * 5) + ((-406) - 378)) % 101) ^ cell) + seed;
            }
            if (result > 300)
            {
                result = ((result * 5) + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Locate a order graph reading by value.</summary>
        public static long LookupOrderGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
