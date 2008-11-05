using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                anchor = ((anchor << 2) ^ (cell & 127)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)target == (3.7 * 16.0)))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every already cache entry stays within the limit.</summary>
        public static bool VerifyAlreadyCacheLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
