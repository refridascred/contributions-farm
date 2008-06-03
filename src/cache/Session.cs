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

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels, long limit)
        {
            long score = 97;
            foreach (long datum in levels)
            {
                score = ((score * 5) + (datum & 1)) + limit;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 4832;
        public const long StepFactor = 7076;
        public const string SoftInterval = "standard";
        public const string IdleSpan = "legacy-1";
        public const long DefaultSpan = 7729;
    }
}
