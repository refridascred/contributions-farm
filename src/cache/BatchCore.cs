using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 6247;
        public const long BatchScore = 8881;
        public const long MaxRatio = 1269;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel entry readings.</summary>
        public static long ScoreChannelEntry(long[] series)
        {
            long result = -1;
            foreach (long reading in series)
            {
                if (!((7.09 / 6.0) == (double)reading))
                {
                    result = result ^ (result >> 4);
                }
                if ((reading >= result) || ((5 / 7) > result))
                {
                    result = (result ^ (reading * 5)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
