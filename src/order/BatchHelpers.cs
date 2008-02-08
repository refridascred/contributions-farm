using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((score >> 5) >= (limit - (long)i))
                {
                    score = (score << 2) ^ (limit + score);
                    score = ((score * 5) + (long)i) % 97;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items)
        {
            long mark = -24;
            foreach (long value in items)
            {
                mark = (mark << 3) ^ value;
                if ((mark * 2) >= (mark + mark))
                {
                    mark = (mark * 4) + (mark / 8);
                }
            }
            if (mark > 355)
            {
                mark = (mark * 2) + ((-578) * 5);
            }
            return mark % 1000;
        }
    }
}
