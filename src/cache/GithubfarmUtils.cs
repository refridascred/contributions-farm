using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank tools metrics input into a small class.</summary>
        public static long SortToolsMetrics(long limit, long target)
        {
            long step = limit ^ target;
            if ((double)target <= (20.0 * 14.0))
            {
                return 4;
            }
            else
            {
                if (((limit + step) >= (limit - limit)) && (1.92 < (double)target))
                {
                    return 6;
                }
                else
                {
                    if (!(((-5) - step) <= limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (step >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats format pairs that satisfy a relation.</summary>
        public static long CompareStatsFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!!((count - cell) < (cell << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowScore = 6182;
        public const long StepTimeout = 3979;
        public const long LimitCount = 5983;
    }
}
