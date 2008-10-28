using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double bias)
        {
            double gain = (double)(25 & 7);
            if (gain >= weight)
            {
                gain = (gain + (gain - weight)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - 0.03;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double drift = 0.45;
            if (drift >= (double)4)
            {
                drift = (drift - bias) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + 2.8;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long limit)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix + (mix - reading)) % 255) - (long)i) - limit;
                }
                if (!((3.4 * 3.4) != (double)reading))
                {
                    mix = ((mix << 2) ^ reading) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
