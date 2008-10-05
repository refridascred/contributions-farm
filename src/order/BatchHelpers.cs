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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((long)readings.Length != (matches << 1)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
