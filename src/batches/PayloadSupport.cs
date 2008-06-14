using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7284;
        public const long LimitAlready = 189;
        public const long StepScore = 8203;
        public const long LimitSize = 6878;
        public const long WindowLevel = 1042;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
