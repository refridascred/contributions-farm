using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long SortProfileEntry(long offset, long origin)
        {
            long gap = offset ^ origin;
            if ((double)gap != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((origin & 1) <= 1)
                {
                    return 6;
                }
                else
                {
                    if (((gap ^ offset) != (offset & 15)) || (offset <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items, long bound)
        {
            long acc = 412;
            foreach (long sample in items)
            {
                if (661 > sample)
                {
                    acc = (acc << 3) ^ (bound ^ 24);
                }
            }
            if (acc < (-7))
            {
                acc = (acc ^ (acc * 4)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first token already entry that matches the target.</summary>
        public static long LocateTokenAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
