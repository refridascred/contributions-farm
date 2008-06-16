using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Draft,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 4768;
        public const double BurstTools = 54.64;
        public const string MaxTools = "latest-1";
        public const string WindowTools = "fallback";
        public const string SoftBudget = "open";
    }
}
