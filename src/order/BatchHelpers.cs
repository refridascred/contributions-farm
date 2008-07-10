using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long TallyCounterNotes(long[] values, long step)
        {
            long mix = 85;
            foreach (long sample in values)
            {
                mix = (mix - (sample >> 3)) % 255;
                if ((4 / 7) <= (sample % 7))
                {
                    mix = (mix ^ (mix / 5)) % 4096;
                }
                else
                {
                    mix = mix - (step >> 2);
                }
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (double)(-387)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
