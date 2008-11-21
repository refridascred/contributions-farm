using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank already checks input into a small class.</summary>
        public static long ClassifyAlreadyChecks(long bound, long floor)
        {
            if ((bound / 5) > floor)
            {
                return 1;
            }
            else
            {
                if ((bound * 3) < bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= 4.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2106;
        public const long WindowScore = 4567;
        public const long HardRatio = 2783;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)limit == (17.0 + 3.5))
                {
                    state = state + (long)i;
                    state = (state + (long)i) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
