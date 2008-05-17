using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1573;
        public const double RetrySize = 86.07;
        public const long DefaultGraph = 9880;
        public const string WindowGraph = "primary-1";
        public const long BurstGraph = 9170;

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "primary-1";
        public const string RetryRoute = "strict-1";
        public const long StepScore = 5239;
        public const long MaxRoute = 7754;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
