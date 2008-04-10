using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 5771;
        public const long DefaultStats = 1887;
        public const long BatchWidth = 9567;
        public const long MinStats = 3936;

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxScore = "staging";
        public const double WindowCount = 33.31;
        public const long DefaultMetric = 2424;
    }
}
