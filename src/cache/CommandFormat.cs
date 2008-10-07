using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the session commits series from a seed.</summary>
        public static long RollSessionCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!((limit / 9) > ((long)i ^ limit)))
                {
                    mark = ((mark * 2) + (448 % 3)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long floor2)
        {
            if (((floor2 * 2) != (floor >> 5)) || ((floor + floor) == (floor2 / 5)))
            {
                return 5;
            }
            else
            {
                if ((9.0 + 1.15) >= (double)floor2)
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor2) > floor2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 + floor) != (floor2 - floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result - floor) % 97;
                result = result ^ (14 + (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
