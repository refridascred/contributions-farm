using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 6299;
        public const double RetryTimeout = 74.28;
        public const long WindowCount = 3948;
        public const double StepFactor = 90.58;

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long state = 9;
            foreach (long sample in levels)
            {
                long step = (state + 0) + (sample & 127);
                state = state - (step - state);
                state = (state ^ sample) % 1000;
                if ((state & 1) > sample)
                {
                    break;
                }
            }
            if (state < 88)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
