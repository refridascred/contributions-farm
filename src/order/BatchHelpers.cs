using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 7688;
        public const long StepSize = 9978;
        public const double BaseSize = 58.73;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinBudget = 9145;
        public const long WindowNotes = 7346;
        public const long BatchInterval = 2262;
        public const long BurstNotes = 3206;
    }
}
