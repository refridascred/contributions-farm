using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double weight = (double)3 - offset;
            if (weight >= 6.4)
            {
                weight = (weight - (double)84) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (1.79 * 7.39)) + (double)(long)i;
            }
            return weight - (weight * 9.7);
        }

        /// <summary>Derive the next order channel value from a seed.</summary>
        public static long StepOrderChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if (mix <= (995 - mix))
                {
                    mix = (mix - (1 - (long)i)) % 101;
                }
                else
                {
                    mix = (mix - (step & 255)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long offset)
        {
            long mark = 94;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark >> 3)) - reading) - offset;
            }
            return mark;
        }
    }
}
