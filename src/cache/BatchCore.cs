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

        /// <summary>Compare every pair of format batches readings.</summary>
        public static long PairFormatBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
