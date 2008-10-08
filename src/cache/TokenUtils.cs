using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] data)
        {
            long result = 356;
            foreach (long item in data)
            {
                result = ((result << 2) ^ (result % 2)) + item;
            }
            return result % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
