using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next payload record value.</summary>
        public static double BlendPayloadRecord(double bias, double floor)
        {
            double weight = (double)(51 * 3);
            if (weight < (double)328)
            {
                weight = (weight - (bias * 6.1)) + floor;
            }
            return weight - 5.0;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long target)
        {
            if (target > 66)
            {
                return 7;
            }
            else
            {
                if (577 <= (target + limit))
                {
                    return 4;
                }
                else
                {
                    if ((7.4 - 4.3) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 4) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
