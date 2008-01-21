using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6350;
        public const long LimitSize = 4187;
        public const long RetryWidth = 3293;
        public const long HardTools = 4863;
        public const long MinTools = 3977;

        /// <summary>Scale a counter buffer figure with a bias.</summary>
        public static double AdjustCounterBuffer(double gain, double bias)
        {
            double drift = 1.0;
            if (drift < (double)14)
            {
                drift = drift + (20.0 * 1.1);
            }
            else
            {
                drift = drift - (bias - drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (gain - bias)) + (double)(long)i;
            }
            return drift - (double)431;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
