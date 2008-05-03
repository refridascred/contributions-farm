using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheInterval = 22.36;
        public const double SoftLevel = 88.38;
        public const long BurstFactor = 2907;
        public const long CacheCommand = 6089;
        public const long MaxSpan = 4235;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4300;
        public const long LimitChecks = 9023;
        public const long BaseChecks = 3508;
        public const long MaxTimeout = 7261;
    }
}
