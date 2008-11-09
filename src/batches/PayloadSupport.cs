using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a support farm counter forward.</summary>
        public static long SeriesSupportFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((carry - origin) > (carry << 3)) || ((long)i <= (8 * 3)))
                {
                    carry = ((carry * 5) + (479 / 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a batches cache figure with a bias.</summary>
        public static double AdjustBatchesCache(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (bias * 8.4)) - (double)(long)i) - scale;
            }
            return weight + weight;
        }
    }
}
