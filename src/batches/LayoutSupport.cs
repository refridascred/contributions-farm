using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 5293;
        public const double WindowPayload = 70.95;
        public const long IdlePayload = 47;
        public const long RetryPayload = 5359;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (9.51 - weight))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - 2.7;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (weight * 7.94);
        }
    }
}
