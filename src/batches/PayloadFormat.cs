using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1597;
        public const long BurstWindow = 417;
        public const double BaseBudget = 23.0;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((result - 37) > bound)
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples)
        {
            long total = 8;
            foreach (long value in samples)
            {
                if ((total + total) < (53 + value))
                {
                    total = (total * 4) + (-58);
                }
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)limit >= (3.7 * 3.3)) && ((entry << 2) > 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
