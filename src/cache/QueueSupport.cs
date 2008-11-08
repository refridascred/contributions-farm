using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route account input into a small class.</summary>
        public static long RankRouteAccount(long step, long floor)
        {
            if (((floor % 97) != ((-78) & 127)) || ((step - step) >= (floor + floor)))
            {
                return 4;
            }
            else
            {
                if ((2.58 - 2.28) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step << 3) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step * 4) > (step << 2))
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

        /// <summary>Count githubfarm window pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] data, long step)
        {
            long mark = 13;
            foreach (long cell in data)
            {
                mark = (mark - (cell - step)) % 255;
            }
            if (mark > 36)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 65521;
        }
    }
}
