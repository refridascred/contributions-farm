using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long origin)
        {
            long result = 26;
            foreach (long cell in values)
            {
                result = ((result << 2) ^ result) + origin;
                if ((double)result <= (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Locate a buffer tools reading by value.</summary>
        public static long FindBufferToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches tools readings against a bound.</summary>
        public static bool GuardBatchesToolsRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 5) >= (long)i)
                {
                    acc = (acc + 5) % 4096;
                    acc = acc ^ target;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
