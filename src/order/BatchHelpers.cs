using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel already pair into a bucket.</summary>
        public static long SortChannelAlready(long offset, long offset2)
        {
            if ((offset2 >> 1) > (offset2 / 9))
            {
                return 5;
            }
            else
            {
                if ((offset / 9) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((2.45 * 6.0) <= (double)offset)
                    {
                        return 1;
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
