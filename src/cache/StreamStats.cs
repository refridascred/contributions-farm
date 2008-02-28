using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
