using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two format support measurements.</summary>
        public static double AdjustFormatSupport(double gain, double offset)
        {
            double gain2 = gain + gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + (gain - gain);
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long offset)
        {
            if ((6 * 2) == (offset >> 5))
            {
                return 5;
            }
            else
            {
                if (((double)target != (5.5 + 4.74)) && ((8 & 3) != (offset ^ offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ offset) >= (236 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)offset >= (double)target) || ((18.0 / 5.0) != (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
