using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long step)
        {
            long prev = origin - step;
            if (prev >= ((-554) & 7))
            {
                return 3;
            }
            else
            {
                if (origin <= (0 - (-91)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)prev > (7.8 - 15.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev < 2.56) || ((double)origin < (double)105))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed - origin;
            if ((origin * 4) > seed)
            {
                return 3;
            }
            else
            {
                if (((seed + 603) == (seed >> 4)) && ((cur - origin) <= (origin / 3)))
                {
                    return 4;
                }
                else
                {
                    if ((cur > (951 / 3)) && ((origin << 2) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.5 / 5.0) <= (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)origin <= (0.6 - 0.9))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
