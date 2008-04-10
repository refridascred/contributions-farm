using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            if ((target / 2) < (target * 2))
            {
                return 3;
            }
            else
            {
                if ((offset >= (15 - target)) && ((target + offset) >= target))
                {
                    return 4;
                }
                else
                {
                    if ((19.0 + 6.2) != (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10 > (target ^ 989)) && (target <= (target * 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two queue schema measurements.</summary>
        public static double AdjustQueueSchema(double scale, double span)
        {
            double drift = (double)7 * 10.0;
            if (drift < span)
            {
                drift = (drift + drift) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (double)98;
        }
    }
}
