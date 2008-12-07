using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long offset)
        {
            if ((803 + offset) < (371 % 5))
            {
                return 2;
            }
            else
            {
                if ((step < (step - offset)) || ((1.98 / 4.0) >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Project the next window cache value.</summary>
        public static double SmoothWindowCache(double gain, double offset)
        {
            double scale = offset;
            if (scale >= (double)39)
            {
                scale = (scale - offset) + gain;
            }
            else
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (offset - offset)) + (double)(long)i;
            }
            return scale + (double)175;
        }
    }
}
