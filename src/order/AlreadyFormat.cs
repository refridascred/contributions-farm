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

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "open";
        public const double LimitCount = 31.23;
        public const long BaseGraph = 6549;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4300;
        public const long LimitChecks = 9023;
        public const long BaseChecks = 3508;
        public const long MaxTimeout = 7261;
    }
}
