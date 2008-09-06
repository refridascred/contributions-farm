using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long target)
        {
            long prev = origin - target;
            if ((origin * 4) < (origin + target))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) == (prev << 3))
                {
                    return 0;
                }
                else
                {
                    if (!(target <= prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev >> 5) != (target - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long limit)
        {
            if (((5.8 / 9.0) > (double)origin) || ((26 % 64) == (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((origin + limit) <= origin)
                {
                    return 4;
                }
                else
                {
                    if ((limit - origin) >= (limit + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin > (double)537)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 3447;
        public const long IdleGithubfarm = 7198;
        public const string WindowCount = "local-1";
        public const long StepInterval = 6671;
    }
}
