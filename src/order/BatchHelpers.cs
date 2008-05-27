using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a context counter sample.</summary>
        public static long LocateContextCounterIndex(long[] levels, long target)
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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 6947;
        public const long DefaultLevel = 1241;
        public const long StepToken = 7687;
        public const string DefaultToken = "strict-1";
    }
}
