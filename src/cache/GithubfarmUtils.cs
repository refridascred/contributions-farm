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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix * 4) + (long)i;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
