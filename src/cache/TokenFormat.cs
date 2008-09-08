using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 137;
        public const double HardFilter = 14.16;
        public const string CacheWidth = "local-v2";
        public const long RetryFilter = 481;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((61 ^ cell) >= (step - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
