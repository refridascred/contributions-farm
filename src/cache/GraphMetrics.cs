using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long bound)
        {
            long acc = 84;
            foreach (long value in readings)
            {
                acc = (((acc * 3) + (bound ^ acc)) % 65521) + value;
            }
            if (acc < 90)
            {
                acc = (acc << 2) ^ bound;
            }
            return acc;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long floor)
        {
            if ((double)bound == (double)507)
            {
                return 2;
            }
            else
            {
                if ((4.0 / 3.0) < (9.0 + 12.0))
                {
                    return 3;
                }
                else
                {
                    if ((58 - floor) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a metrics stream counter forward.</summary>
        public static long StepMetricsStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + (limit ^ (long)i);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
