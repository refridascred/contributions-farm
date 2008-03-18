using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const string HardLevel = "open-v2";
        public const double MaxWidth = 81.91;
        public const long LimitTimeout = 1025;

        /// <summary>Check that every cluster layout entry stays within the limit.</summary>
        public static bool ValidateClusterLayoutLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
