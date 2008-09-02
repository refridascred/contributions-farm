using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool GuardWindowChecksLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine format editor values into a single score.</summary>
        public static long TallyFormatEditor(long[] readings)
        {
            long sum = 65;
            foreach (long entry in readings)
            {
                sum = ((sum << 2) ^ (sum + sum)) ^ entry;
            }
            if (sum < 29)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((3.21 * 10.0) > (double)hits) || ((double)sample != (9.0 * 5.4)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
