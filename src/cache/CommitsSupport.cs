using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit + 9) > limit)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long sum = 88;
            foreach (long datum in data)
            {
                if ((double)origin <= (5.0 / 7.0))
                {
                    sum = ((sum ^ (223 & 255)) % 4096) ^ datum;
                }
                else
                {
                    sum = sum - (origin * 2);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long seed)
        {
            if ((floor & 7) < (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) == (seed >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally <= 1)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) >= (5 << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
