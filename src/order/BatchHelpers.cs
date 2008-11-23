using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "staging";
        public const double SoftCommand = 98.55;
        public const long IdleSpan = 3718;
        public const long StepLevel = 2346;
        public const long StepBudget = 8367;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Draft,
            Queued,
            Closed,
        }
    }
}
