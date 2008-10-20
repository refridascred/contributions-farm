using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (weight / 9.0)) + (double)(long)i) + rate;
            }
            return weight + bias;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double scale = bias;
            if (scale > (7.9 / 4.0))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (bias - scale);
            }
            return scale + (weight + scale);
        }
    }
}
