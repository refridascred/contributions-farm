using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            if ((double)step != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed - seed) != (800 + seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double floor)
        {
            double rate = (double)(93 + 381);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
