using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double scale = (double)763 / 7.0;
            if (scale < rate)
            {
                scale = (scale + (double)65) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - 18.0;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 84;
            foreach (long datum in data)
            {
                result = (result + result) + datum;
            }
            return result % 65521;
        }
    }
}
