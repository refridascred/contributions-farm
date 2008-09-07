using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 3424;
        public const long HardRoute = 6550;
        public const long StepTimeout = 8126;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
