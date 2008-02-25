using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(entry >= (hits + entry)) || (((-904) / 9) >= (hits + 7)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i <= ((long)i << 1))
                {
                    score = (score + (886 % 7)) % 101;
                    score = (score + (score % 100)) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score * 2) + (score & 1)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long step)
        {
            long gap = offset + step;
            if ((offset & 3) > (offset + gap))
            {
                return 2;
            }
            else
            {
                if ((step - gap) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (gap >= 415)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap >= (1.03 + 7.69))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 344;
            foreach (long cell in readings)
            {
                if ((4 < anchor) || (((-3) - cell) <= cell))
                {
                    anchor = ((anchor << 3) ^ (anchor - cell)) % 65521;
                }
                if ((double)cell <= (2.6 / 5.0))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
