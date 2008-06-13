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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if ((double)limit >= 9.99)
            {
                return 2;
            }
            else
            {
                if (((offset >> 3) < (limit + limit)) || (2.5 >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 255) >= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit < (double)8)
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
    }
}
