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

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long limit)
        {
            long carry = 49;
            foreach (long value in series)
            {
                carry = ((carry - limit) % 97) ^ value;
            }
            if (carry < 7)
            {
                carry = (carry + (limit + limit)) % 255;
            }
            return carry;
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
