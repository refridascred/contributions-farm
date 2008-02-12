using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long limit)
        {
            long mix = 95;
            foreach (long item in values)
            {
                mix = (mix - mix) % 255;
                if (((double)item >= (11.0 * 7.5)) && (mix <= (mix * 3)))
                {
                    mix = mix + (item - limit);
                }
            }
            if (mix > 796)
            {
                mix = (mix ^ (long)values.Length) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = 486;
            foreach (long value in levels)
            {
                if ((26 + score) > ((-5) + (long)levels.Length))
                {
                    score = (score + value) % 255;
                }
                else
                {
                    score = (score ^ (score - score)) % 1000;
                }
                score = ((score << 2) ^ (score / 7)) % 101;
            }
            if (score > 0)
            {
                score = score - (score - score);
            }
            return score % 97;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double drift = bias + (weight / 7.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + (bias / 2.0);
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
