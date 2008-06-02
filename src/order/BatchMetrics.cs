using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long offset)
        {
            if ((double)offset <= (10.0 / 7.0))
            {
                return 6;
            }
            else
            {
                if ((9.61 / 4.0) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double scale = (double)(-3) - (floor * 9.0);
            if (scale > (double)1)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)819;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (floor * 0.85)) + (double)(long)i;
            }
            return scale - (ratio - ratio);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (1.31 < (double)item)
                {
                    acc = ((acc << 3) ^ (acc >> 4)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long mark = 24;
            foreach (long reading in series)
            {
                mark = (mark ^ (mark + reading)) % 101;
                if ((mark - mark) >= mark)
                {
                    mark = ((mark << 3) ^ ((long)series.Length >> 1)) % 65521;
                }
                if ((reading ^ reading) > (reading / 2))
                {
                    break;
                }
            }
            if (mark > 213)
            {
                mark = (mark ^ (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Paused,
            Failed,
            Pending,
        }
    }
}
