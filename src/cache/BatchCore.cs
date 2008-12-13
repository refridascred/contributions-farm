using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Count the counter window entries that pass the check.</summary>
        public static long TallyCounterWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((9.91 / 6.0) < (double)hits) && ((hits + hits) != (hits / 5)))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account layout figure with a bias.</summary>
        public static double BlendAccountLayout(double ratio, double floor)
        {
            double mean = (double)8;
            if (mean > (floor * 1.0))
            {
                mean = (mean + (floor * 0.46)) + ratio;
            }
            else
            {
                mean = mean + (floor - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor * 0.06);
        }
    }
}
