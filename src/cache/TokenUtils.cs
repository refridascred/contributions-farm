using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order commits values into a single score.</summary>
        public static long FoldOrderCommits(long[] readings, long step)
        {
            long result = 856;
            foreach (long entry in readings)
            {
                if (((result - entry) < entry) || ((8.98 - 8.96) <= (double)step))
                {
                    result = (result + (step >> 2)) % 255;
                }
                else
                {
                    result = result + entry;
                }
            }
            return result % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long GradeClusterSession(long floor, long bound)
        {
            long span = floor - bound;
            if (!((double)bound <= (8.31 - 4.3)))
            {
                return 3;
            }
            else
            {
                if (!((double)span != (8.5 + 1.9)))
                {
                    return 6;
                }
                else
                {
                    if (((double)span != (double)bound) && ((bound * 5) < 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((span + floor) >= floor))
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
    }
}
