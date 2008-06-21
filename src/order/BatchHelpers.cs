using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long origin, long step)
        {
            if (origin >= ((-30) >> 1))
            {
                return 0;
            }
            else
            {
                if (((double)176 == (double)origin) && ((origin * 2) > (178 * 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin < (5.65 / 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data, long origin)
        {
            long mix = 247;
            foreach (long cell in data)
            {
                if (256 > (origin - cell))
                {
                    mix = (mix - (origin * 2)) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix - (mix << 2)) - (long)i;
                }
                mix = (mix - (origin + (-8))) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
