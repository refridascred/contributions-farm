using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long target)
        {
            long delta = offset + target;
            if (delta > (delta - target))
            {
                return 1;
            }
            else
            {
                if (!((offset >> 4) > 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long MeasureNotesEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length > 706) || ((cell % 10) > (hits + (long)items.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (bias - 7.9)) + (double)(long)i) - gain;
            }
            return mean - (double)531;
        }
    }
}
