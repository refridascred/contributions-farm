using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstBudget = "standard-v2";
        public const string WindowDepth = "local";
        public const long DefaultTimeout = 7964;
        public const long MinCount = 6093;
        public const long RetryCounter = 4413;

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ limit) ^ sample;
                if (!((mix % 2) < 0))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 5) + ((-92) - mix)) % 65521;
            }
            return mix % 4096;
        }
    }
}
