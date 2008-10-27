using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 1794;
        public const long BurstCommand = 2038;
        public const long HardCommand = 9122;
        public const string MaxCommand = "standard-edge";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((cell + cell) >= (cell >> 5)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 21.16;
        public const double BurstFilter = 90.79;
        public const long IdleSize = 3079;
        public const long HardFactor = 3675;
        public const double RetryFilter = 55.87;
    }
}
