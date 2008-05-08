using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            New,
            Retry,
            Closed,
        }

        /// <summary>Roll a contributi context counter forward.</summary>
        public static long RollContributiContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = state ^ (limit + (long)i2);
                    state = ((state * 3) + (limit & 255)) % 97;
                }
                state = (state + 5) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 7048;
        public const long HardFactor = 1194;
        public const long StepCount = 5968;

        /// <summary>Validate profile cluster readings against a bound.</summary>
        public static bool VerifyProfileClusterBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
