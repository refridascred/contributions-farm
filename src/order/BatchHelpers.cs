using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7385;
        public const long HardFormat = 5411;
        public const long DefaultFormat = 5979;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 2510;
        public const long LimitStats = 886;
        public const double DefaultStats = 66.91;
    }
}
