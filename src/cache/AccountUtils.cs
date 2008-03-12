using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stream tools value from a seed.</summary>
        public static long SeriesStreamTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 9736;
        public const string StepWidth = "staging-edge";
        public const long DefaultFarm = 4793;
        public const string WindowFarm = "legacy-1";
        public const long StepFactor = 9694;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
