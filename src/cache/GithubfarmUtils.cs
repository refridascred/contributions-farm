using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = (gain2 - (double)98) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + 3.38) + (double)(long)i;
            }
            return gain2 - (double)6;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit * 3) > limit)
                {
                    state = state - state;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long origin)
        {
            if ((12.0 / 8.0) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit >= (7.8 + 5.0)) && ((limit + limit) < limit))
                {
                    return 4;
                }
                else
                {
                    if ((9.92 / 9.0) != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit == (4.0 - 4.2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark % 7) == (origin ^ (long)i))
                {
                    mark = mark + (mark ^ mark);
                    mark = (mark - (origin + (long)i)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark >> 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
