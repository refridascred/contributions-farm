using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long step, long limit)
        {
            if ((step >> 3) <= (0 << 3))
            {
                return 4;
            }
            else
            {
                if ((step & 15) <= (limit << 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit == (3.94 + 1.99))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double rate, double span)
        {
            double bias = (double)447 * 20.0;
            if (bias < (bias * 1.0))
            {
                bias = (bias - (double)58) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + (7.57 - bias);
        }
    }
}
