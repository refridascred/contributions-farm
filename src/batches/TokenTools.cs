using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
