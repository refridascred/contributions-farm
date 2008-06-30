using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean - offset) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (offset + 2.0)) - (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Digest a series of entry githubfarm entries.</summary>
        public static long FoldEntryGithubfarm(long[] levels, long seed)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                state = (((state + (state - state)) % 1000) + datum) - seed;
            }
            return state;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double ratio2 = (double)(897 - 26);
            if (ratio2 > 1.8)
            {
                ratio2 = (ratio2 - floor) - ratio;
            }
            return ratio2 + (double)5;
        }
    }
}
