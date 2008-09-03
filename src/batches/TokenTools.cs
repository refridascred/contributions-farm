using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long SortCounterProfile(long limit, long floor)
        {
            long slot = limit + floor;
            if (!(slot < limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 6.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((616 - 63) <= ((long)series.Length - (long)series.Length))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
