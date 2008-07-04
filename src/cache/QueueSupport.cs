using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the commits queue series from a seed.</summary>
        public static long IterateCommitsQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items)
        {
            long mix = 7;
            foreach (long datum in items)
            {
                if ((mix + mix) <= datum)
                {
                    mix = (mix << 2) ^ (datum & 255);
                }
                else
                {
                    mix = mix - (mix * 5);
                }
            }
            return mix;
        }
    }
}
