using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepTimeout = 9.16;
        public const double BatchScore = 31.92;
        public const long BatchBatches = 6517;
        public const string BatchLevel = "latest-1";
        public const double BatchInterval = 76.09;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)seen < (14.0 / 6.0)))
                {
                    seen = ((seen + 3) + value) + step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) != (offset % 2))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
