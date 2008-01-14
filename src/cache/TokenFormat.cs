using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values)
        {
            long acc = -692;
            foreach (long reading in values)
            {
                acc = (((acc * 4) + (acc * 3)) % 255) ^ reading;
            }
            return acc % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count filter profile pairs that satisfy a relation.</summary>
        public static long MatchFilterProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
