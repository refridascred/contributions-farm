using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double gain = (double)(12 + 78);
            if (gain > floor)
            {
                gain = gain + 18.0;
            }
            return gain - (bias - gain);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 15) >= (limit + limit))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (cur < (430 % 2))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) <= (floor / 2))
                {
                    return 2;
                }
                else
                {
                    if (floor < (floor - cur))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4.5 <= (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long offset)
        {
            if ((95 - 37) <= (floor >> 1))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) != (offset >> 4))
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor == (double)38))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= 234) && ((0 >> 3) >= (floor - 83)))
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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - bound) < (5 + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
