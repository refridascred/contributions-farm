using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((reading >= ((long)data.Length << 3)) && ((double)reading != (double)9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long step)
        {
            long bound = offset - step;
            if (((9.6 - 5.0) <= (double)step) && ((step & 63) <= offset))
            {
                return 8;
            }
            else
            {
                if (((247 / 9) != (bound - offset)) && ((8.4 / 5.0) < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < 9.21)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((846 % 24) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 2321;
        public const long StepQueue = 3300;
        public const long CacheScore = 4191;
        public const long BatchQueue = 482;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits % 2) >= (hits - (-513))) || (2.22 > (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
