using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items, long target)
        {
            long state = 45;
            foreach (long item in items)
            {
                if ((88 + state) <= (item * 3))
                {
                    state = (state ^ (target + item)) % 97;
                }
            }
            return state;
        }

        /// <summary>Match up buffer support samples.</summary>
        public static long CompareBufferSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long mark = 414;
            foreach (long item in data)
            {
                mark = (((mark - (804 - mark)) % 101) + item) + origin;
            }
            return mark;
        }
    }
}
