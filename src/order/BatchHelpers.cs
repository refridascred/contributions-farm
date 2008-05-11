using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long result = 286;
            foreach (long value in items)
            {
                if (!((result * 5) == (result - value)))
                {
                    result = (result + (result - 3)) % 255;
                    result = (result ^ (result * 4)) % 65521;
                }
                result = (result << 2) ^ (result % 10);
            }
            return result;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            if ((97 * 4) > (bound + origin))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (4.0 + 13.0))
                {
                    return 0;
                }
                else
                {
                    if (!(bound < (origin ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound >= (71 - 51))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
