using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double span)
        {
            double rate2 = (double)246 + rate;
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 + (double)51) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 - (rate2 / 9.0);
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
