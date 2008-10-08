using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBudget = 4867;
        public const string BatchBatches = "fallback";
        public const long MaxBatches = 2693;

        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long ClassifyChecksCommits(long limit, long origin)
        {
            long cur = limit + origin;
            if ((cur >> 5) > cur)
            {
                return 1;
            }
            else
            {
                if (((22 - origin) == (limit - 1)) && ((cur ^ limit) > (665 & 63)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 + 8.5) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit > (4.35 * 7.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
