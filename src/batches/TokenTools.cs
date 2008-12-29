using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)(long)samples.Length < (double)18) && ((matches & 31) >= matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long acc = 548;
            foreach (long sample in data)
            {
                acc = ((acc * 5) + (sample ^ sample)) % 4096;
            }
            if (acc > 7)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
