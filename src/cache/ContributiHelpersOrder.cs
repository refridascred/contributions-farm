using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if (((1.08 + 7.25) <= (double)target) || ((target * 4) > target))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a metrics filter reading by value.</summary>
        public static long SeekMetricsFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples, long bound)
        {
            long anchor = 9;
            foreach (long item in samples)
            {
                if (!((double)bound < 3.02))
                {
                    anchor = ((anchor + (anchor << 2)) % 65521) ^ item;
                }
            }
            return anchor % 97;
        }
    }
}
