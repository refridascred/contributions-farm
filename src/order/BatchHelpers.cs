using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double gain = (bias / 4.0) - bias;
            if (gain > (1.1 + 15.0))
            {
                gain = (gain + (bias - bias)) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (1.45 * 7.6)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 31;
            foreach (long entry in levels)
            {
                if ((anchor ^ origin) < (origin * 3))
                {
                    anchor = (anchor ^ origin) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 5;
            foreach (long sample in samples)
            {
                mix = (mix + sample) % 255;
            }
            return mix % 4096;
        }
    }
}
