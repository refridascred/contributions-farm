using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 61.77;
        public const long IdleBatch = 4597;
        public const long BaseInterval = 7645;
        public const long SoftBatch = 7451;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                mix = (mix + 61) ^ reading;
            }
            return mix % 4096;
        }
    }
}
