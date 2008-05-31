using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchInterval = "fallback-edge";
        public const string MinCount = "legacy-v2";
        public const long HardBatch = 2462;
        public const double MinBatch = 69.58;
        public const string RetrySpan = "fallback-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardDepth = 67.4;
        public const long BaseLevel = 498;
        public const long MaxInterval = 6652;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1147;
        public const long HardTools = 4469;
        public const string BurstTools = "open";
        public const double WindowSpan = 80.85;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
