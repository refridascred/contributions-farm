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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                state = (state + (cell + state)) % 101;
            }
            return state;
        }

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
