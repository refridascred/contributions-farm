using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 21.18;
        public const string StepFactor = "primary";
        public const long BaseBudget = 5357;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 3011;
        public const long IdleBatch = 4791;
        public const double HardBatch = 40.53;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
