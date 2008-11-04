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

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long state = 55;
            foreach (long item in items)
            {
                state = (state ^ (item >> 1)) % 4096;
            }
            return state % 65521;
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
