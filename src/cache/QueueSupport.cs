using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 16.83;
        public const long BatchFilter = 7041;
        public const long SoftFilter = 9442;
        public const long MaxFilter = 262;
        public const double HardFilter = 43.7;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Closed,
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
