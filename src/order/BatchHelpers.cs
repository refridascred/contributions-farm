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

        /// <summary>Check that every cache farm entry stays within the limit.</summary>
        public static bool CheckCacheFarmBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
