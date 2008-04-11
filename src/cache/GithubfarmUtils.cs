using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long offset)
        {
            long slot = step ^ offset;
            if ((slot > 250) || (step <= (step / 6)))
            {
                return 6;
            }
            else
            {
                if (!((double)offset <= (6.2 * 9.0)))
                {
                    return 3;
                }
                else
                {
                    if ((step / 6) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9.0 * 10.0) >= (double)step) || ((9.93 / 5.0) != (double)offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 849;
            foreach (long value in samples)
            {
                total = ((total * 2) + value) % 97;
                total = (total << 2) ^ (total * 5);
            }
            return total % 4096;
        }
    }
}
