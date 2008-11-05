using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long step)
        {
            if (step < (88 - step))
            {
                return 7;
            }
            else
            {
                if ((4.58 * 7.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
