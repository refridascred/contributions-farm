using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long state = 7;
            foreach (long value in series)
            {
                if (!((state - value) != ((-692) << 2)))
                {
                    state = ((state * 4) + (value & 3)) - origin;
                }
                else
                {
                    state = state - (state & 127);
                }
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (state % 12)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 4832;
        public const long StepFactor = 7076;
        public const string SoftInterval = "standard";
        public const string IdleSpan = "legacy-1";
        public const long DefaultSpan = 7729;
    }
}
