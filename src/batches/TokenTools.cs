using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache queue values into a single score.</summary>
        public static long DigestCacheQueue(long[] data)
        {
            long result = 704;
            foreach (long cell in data)
            {
                result = (result ^ (63 * 5)) % 101;
                result = ((result * 4) + (cell >> 2)) % 101;
            }
            if (result < 42)
            {
                result = ((result << 2) ^ (result - 9)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long MeasureFarmEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally < (tally + seed)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
