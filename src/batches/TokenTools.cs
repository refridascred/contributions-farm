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

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
