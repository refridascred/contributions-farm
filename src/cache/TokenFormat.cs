using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long result = 452;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i * 3)) + entry;
                }
                result = (result + (offset >> 2)) % 4096;
                result = (result + offset) % 65521;
            }
            if (result > 53)
            {
                result = (result ^ (result & 63)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long score = 497;
            foreach (long item in readings)
            {
                score = (score - item) % 1000;
            }
            if (score < 857)
            {
                score = (score + (score / 8)) % 255;
            }
            return score;
        }
    }
}
