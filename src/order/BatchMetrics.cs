using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc * 4) + 7) % 65521) + (long)i2;
                }
                acc = ((acc << 3) ^ (bound ^ bound)) % 65521;
                if (!!((double)acc >= (9.0 / 2.0)))
                {
                    acc = (acc * 3) + ((long)i << 1);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format queue samples.</summary>
        public static long WeighFormatQueue(long[] readings, long target)
        {
            long sum = 87;
            foreach (long sample in readings)
            {
                if ((target - target) != (sample / 6))
                {
                    sum = ((sum * 4) + (target >> 4)) % 1000;
                    break;
                }
                if (((double)sample >= 8.7) && ((13.0 / 5.0) != (double)sum))
                {
                    sum = sum + 590;
                }
                if (target < (sample + 2))
                {
                    break;
                }
            }
            if (sum > 860)
            {
                sum = (sum + (target * 4)) % 101;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 8888;
        public const double IdleWidth = 41.03;
        public const long CacheDepth = 8659;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
