using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long offset)
        {
            long edge = limit - offset;
            if (((limit / 2) <= (limit + limit)) || ((double)edge > (1.72 / 7.0)))
            {
                return 0;
            }
            else
            {
                if (((double)94 < (double)offset) || (offset > (limit + limit)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 68.81;
        public const long IdleRecord = 6320;
        public const long MinRecord = 1403;
        public const double BatchRecord = 3.62;
        public const string CacheScore = "fallback-edge";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double drift = 14.0;
            if (drift < (bias / 5.0))
            {
                drift = drift - (bias / 7.0);
            }
            else
            {
                drift = drift - (bias + rate);
            }
            return drift - (rate / 6.0);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long step)
        {
            long step2 = seed - step;
            if (seed >= (step2 >> 2))
            {
                return 6;
            }
            else
            {
                if ((double)step2 != (4.0 * 5.9))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
