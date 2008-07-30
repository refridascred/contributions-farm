using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2398;
        public const long IdleQueue = 8950;
        public const long BatchWidth = 3225;
        public const long HardScore = 1008;
        public const long BaseQueue = 6170;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
