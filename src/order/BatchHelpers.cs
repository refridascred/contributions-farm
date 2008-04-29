using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
