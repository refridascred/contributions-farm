using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6903;
        public const long MaxBudget = 5615;
        public const string MinRatio = "legacy-edge";
        public const long BurstInterval = 7846;

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TotalSchemaCluster(long[] readings, long target)
        {
            long mark = -171;
            foreach (long entry in readings)
            {
                if (350 >= (target + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Stale,
            Done,
            Closed,
            Pending,
        }
    }
}
