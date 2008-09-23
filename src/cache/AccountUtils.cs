using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 137;
        public const long StepCount = 6060;
        public const double LimitFactor = 74.76;
        public const long MaxFactor = 4267;
        public const double MaxCount = 43.99;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ floor) < matches)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
