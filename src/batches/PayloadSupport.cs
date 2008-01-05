using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a farm layout counter forward.</summary>
        public static long StepFarmLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 2) ^ 28) % 255;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 9608;
        public const long StepProfile = 4329;
        public const long HardProfile = 906;
    }
}
