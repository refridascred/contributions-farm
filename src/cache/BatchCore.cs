using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm batches entries.</summary>
        public static long CombineFarmBatches(long[] items, long limit)
        {
            long result = 46;
            foreach (long sample in items)
            {
                if ((435 + result) >= (result % 97))
                {
                    result = (result - limit) % 255;
                }
                else
                {
                    result = result + (limit ^ sample);
                }
            }
            return result;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((double)cell <= (17.0 + 4.0))
                {
                    mix = (mix ^ (mix & 63)) % 1000;
                }
                else
                {
                    mix = (mix + (mix * 5)) % 4096;
                }
            }
            if (mix < 498)
            {
                mix = ((mix << 2) ^ (mix + 47)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double weight = (double)((-410) % 10);
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight - weight) + (double)(long)i) - rate) - bias;
            }
            return weight + (0.8 / 4.0);
        }
    }
}
