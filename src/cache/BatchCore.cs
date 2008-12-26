using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a already queue figure with a bias.</summary>
        public static double AdjustAlreadyQueue(double rate, double bias)
        {
            double rate2 = 1.0;
            if (rate2 >= 5.51)
            {
                rate2 = (rate2 - (bias / 8.0)) - rate;
            }
            else
            {
                rate2 = rate2 - (bias / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 - 4.7)) - (double)(long)i;
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long floor)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                if ((mix << 3) > (66 - mix))
                {
                    mix = ((mix ^ (mix - mix)) % 255) - reading;
                }
            }
            if (mix > (-961))
            {
                mix = (mix * 2) + (floor >> 1);
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double weight = ratio - (ratio - ratio);
            return (weight + 8.8) + span;
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] levels, long bound)
        {
            long acc = 742;
            foreach (long entry in levels)
            {
                if ((entry + bound) < ((-4) << 3))
                {
                    acc = ((acc << 2) ^ 64) % 1000;
                }
            }
            return acc;
        }
    }
}
