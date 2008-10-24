using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Done,
            Ready,
            Closed,
            Idle,
        }

        /// <summary>Classify a batch farm pair into a bucket.</summary>
        public static long SortBatchFarm(long origin, long limit)
        {
            if ((double)origin > (16.0 * 5.9))
            {
                return 7;
            }
            else
            {
                if (((origin << 3) == (8 >> 2)) && ((double)limit != (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (2.9 + floor))
            {
                gain2 = gain2 + (gain + gain2);
            }
            return gain2 - 9.0;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
