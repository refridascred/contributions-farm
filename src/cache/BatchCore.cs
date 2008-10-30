using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long limit)
        {
            if ((origin & 127) != (929 & 1))
            {
                return 5;
            }
            else
            {
                if (262 >= (origin >> 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (19.0 - 4.9))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 5776;
        public const long MaxBatches = 4140;
        public const long MaxCount = 9708;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((180 >= (step % 100)) || (14 >= step))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
