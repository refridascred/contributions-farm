using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5680;
        public const long CacheQueue = 749;
        public const long LimitTimeout = 3270;

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleCount = 45.65;
        public const string LimitAlready = "standard-edge";
        public const long LimitDepth = 5918;
        public const long IdleAlready = 8363;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
