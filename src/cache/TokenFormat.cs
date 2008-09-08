using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long bound)
        {
            if ((origin * 5) != (origin << 1))
            {
                return 8;
            }
            else
            {
                if ((75 >> 2) <= (origin + bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 5) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - origin) != (origin % 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length + matches) == ((long)series.Length << 3)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long lane = target + origin;
            if ((double)origin != (0.06 / 3.0))
            {
                return 2;
            }
            else
            {
                if (origin >= (origin << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin - lane) < lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((775 / 2) <= (lane % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
