using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((offset - offset2) > (offset2 + offset2))
            {
                return 0;
            }
            else
            {
                if (!((80 + offset2) < 9))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 + offset2) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = (double)((-21) - 304);
            if (weight2 > (floor * 7.3))
            {
                weight2 = weight2 - (9.35 - weight2);
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + 15.0;
        }
    }
}
