using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9817;
        public const long StepBatches = 1218;
        public const long BurstBatches = 2155;
        public const long DefaultSpan = 8656;

        /// <summary>Count the context account entries that pass the check.</summary>
        public static long TallyContextAccountGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry / 6) > (count + entry))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8489;
        public const long StepInterval = 134;
        public const string BaseContributi = "standard-v2";

        /// <summary>Fold a list of queue context readings.</summary>
        public static long ScoreQueueContext(long[] data)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                if (!((reading / 6) != (acc % 64)))
                {
                    acc = (acc * 4) + (acc - 171);
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                }
                if ((double)acc != (10.0 * 2.7))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
