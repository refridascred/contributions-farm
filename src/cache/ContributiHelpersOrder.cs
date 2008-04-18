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

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - 4.9) - (double)(long)i) + ratio;
            }
            return mean + span;
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
