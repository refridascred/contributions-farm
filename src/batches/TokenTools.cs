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

        /// <summary>Count the tools batches entries that pass the check.</summary>
        public static long AuditToolsBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)hits == (double)item) && ((item % 10) > (hits + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
