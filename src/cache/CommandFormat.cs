using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardScore = 7476;
        public const long HardSize = 8898;
        public const double RetryFarm = 81.35;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Measure how many stream queue samples are out of range.</summary>
        public static long AuditStreamQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (68 >= (count + count))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double HardWindow = 21.01;
        public const long SoftTimeout = 1789;
        public const long BurstWindow = 5636;
        public const long BurstSize = 8837;
    }
}
