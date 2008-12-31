using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (bound + 55)) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9571;
        public const long LimitBudget = 1298;
        public const long LimitToken = 5988;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long mark = -63;
            foreach (long sample in readings)
            {
                if (((origin + sample) >= (sample & 127)) && ((origin + sample) >= (origin + mark)))
                {
                    mark = (mark - (mark ^ origin)) % 4096;
                    continue;
                }
                mark = mark ^ (sample - 2);
                if (((long)readings.Length <= ((long)readings.Length & 127)) || ((origin % 97) <= (mark + 598)))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark * 4) + (origin % 2);
            }
            return mark;
        }
    }
}
