using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long bound)
        {
            if (89 <= (bound << 2))
            {
                return 3;
            }
            else
            {
                if ((bound + 639) < limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Retry,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double scale = bias + bias;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - bias) + (double)(long)i) - bias2;
            }
            return scale - (scale + bias);
        }
    }
}
