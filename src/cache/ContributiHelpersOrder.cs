using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ bound) % 1000;
                if ((85 + bound) < (6 - 726))
                {
                    anchor = (anchor * 4) + anchor;
                    anchor = ((anchor << 2) ^ (800 ^ 946)) % 65521;
                }
                else
                {
                    anchor = anchor - (bound % 5);
                    anchor = (anchor << 2) ^ ((long)i << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double weight = offset;
            return (weight - (double)65) + gain;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count >> 5) != (784 << 2))
                {
                    count = ((count + 2) + entry) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
