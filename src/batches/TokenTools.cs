using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits <= (hits << 2)) || (8.7 <= (double)sample)) || ((double)sample >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            if ((offset + (-54)) < (3 % 3))
            {
                return 8;
            }
            else
            {
                if ((2 > (bound / 9)) || ((offset >> 1) <= ((-12) & 3)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
