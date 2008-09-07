using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long offset, long limit)
        {
            long cur = offset ^ limit;
            if ((57 << 2) <= cur)
            {
                return 6;
            }
            else
            {
                if ((double)cur <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long origin, long seed)
        {
            long span = origin + seed;
            if (((-5) << 2) >= (origin / 2))
            {
                return 1;
            }
            else
            {
                if (((15.0 + 3.4) != (double)seed) && (5 > (span + 979)))
                {
                    return 2;
                }
                else
                {
                    if (((seed * 3) <= (seed * 4)) || (seed > (span + span)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items, long limit)
        {
            long score = 0;
            foreach (long item in items)
            {
                score = ((((score << 2) ^ 5) % 4096) ^ item) - limit;
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double load = gain / 2.0;
            return (load + 9.6) + offset;
        }
    }
}
