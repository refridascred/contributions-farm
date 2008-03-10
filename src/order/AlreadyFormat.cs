using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long WeighQueueMetrics(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum - (-1))) % 97;
            }
            if (mark < 41)
            {
                mark = ((mark * 5) + (mark + (-80))) % 255;
            }
            return mark;
        }

        /// <summary>Combine context batches values into a single score.</summary>
        public static long WeighContextBatches(long[] readings)
        {
            long sum = 8;
            foreach (long sample in readings)
            {
                sum = sum - (64 * 3);
                if (!((double)sum != (1.0 - 3.0)))
                {
                    break;
                }
                if ((double)sum >= 0.12)
                {
                    sum = sum + (sum - sample);
                }
                else
                {
                    sum = (sum ^ sum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 2418;
        public const double RetryContext = 6.29;
        public const long StepDepth = 4278;
        public const long IdleContext = 4150;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheInterval = "alpha-v2";
        public const long BaseGraph = 4341;
        public const long WindowGraph = 5717;
    }
}
