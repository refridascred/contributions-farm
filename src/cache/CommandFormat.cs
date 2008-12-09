using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstCount = 5545;
        public const double SoftWidth = 63.54;
        public const string MaxPayload = "stable-edge";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) <= tally)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels)
        {
            long carry = 300;
            foreach (long sample in levels)
            {
                if (carry <= (510 - carry))
                {
                    carry = carry ^ (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
