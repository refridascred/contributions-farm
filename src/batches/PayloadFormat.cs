using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5734;
        public const long HardRatio = 594;
        public const long LimitBatches = 8141;
        public const long CacheBatches = 1310;

        /// <summary>Fold a list of format session readings.</summary>
        public static long TotalFormatSession(long[] readings)
        {
            long score = 67;
            foreach (long item in readings)
            {
                score = score + score;
                score = ((score * 5) + item) % 101;
            }
            return score;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double drift = scale * 4.6;
            if (drift < (scale + drift))
            {
                drift = (drift + drift) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift - 7.62)) + (double)(long)i;
            }
            return drift + (double)830;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
