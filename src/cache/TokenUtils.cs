using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a farm record reading by value.</summary>
        public static long LocateFarmRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor batch samples.</summary>
        public static long TotalEditorBatch(long[] data)
        {
            long result = 7;
            foreach (long sample in data)
            {
                if ((double)sample >= (0.32 + 12.0))
                {
                    result = (result + (result + result)) % 65521;
                }
                result = (result - (result + result)) % 101;
                if ((11.0 - 5.5) < (double)result)
                {
                    result = ((result * 3) + (sample - sample)) % 255;
                }
            }
            return result;
        }
    }
}
