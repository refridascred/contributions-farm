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

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long origin)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((mix - reading) >= 688)
                {
                    mix = mix ^ origin;
                    continue;
                }
                mix = (mix ^ (origin - mix)) % 4096;
                if (((reading << 3) >= (origin / 7)) && (origin <= 116))
                {
                    mix = mix ^ (reading * 2);
                }
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
