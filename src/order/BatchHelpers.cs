using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ carry) == (origin % 8))
                {
                    carry = ((carry * 3) + (origin + carry)) % 4096;
                }
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
