using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long total = -96;
            foreach (long sample in readings)
            {
                if ((total >> 1) > sample)
                {
                    total = (total + (927 / 4)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long BatchGithubfarm = 2259;
        public const double HardSpan = 97.27;
    }
}
