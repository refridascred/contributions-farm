using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4801;
        public const double BatchDepth = 73.51;
        public const long BurstStream = 6410;
        public const string CacheStream = "latest-edge";
        public const long HardCount = 1643;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultSpan = 3263;
        public const long MaxFactor = 6195;
        public const string DefaultWidth = "local-v2";
        public const long StepTimeout = 6779;
        public const long CacheContributi = 5958;

        /// <summary>Combine tools report values into a single score.</summary>
        public static long CombineToolsReport(long[] values, long floor)
        {
            long result = -37;
            foreach (long reading in values)
            {
                if (reading < result)
                {
                    result = (result - (result - reading)) + floor;
                }
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5030;
        public const long RetryQueue = 2912;
        public const long WindowQueue = 488;
        public const double BaseRatio = 31.29;
        public const long MinQueue = 5756;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
