using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 7789;
        public const long DefaultSize = 2313;
        public const long HardWidth = 5620;
        public const long LimitContributi = 7343;
        public const long SoftBudget = 7398;

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] readings)
        {
            long total = 895;
            foreach (long reading in readings)
            {
                total = (total ^ (73 / 5)) ^ reading;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
