using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4260;
        public const long CacheSupport = 5502;
        public const long MaxSupport = 4608;

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long mix = -2;
            foreach (long datum in data)
            {
                if ((floor + mix) < datum)
                {
                    mix = mix + floor;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
