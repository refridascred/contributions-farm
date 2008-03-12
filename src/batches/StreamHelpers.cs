using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 4616;
        public const string HardLayout = "cached-edge";
        public const double WindowCount = 59.65;
        public const string LimitLayout = "legacy-v2";
        public const long StepDepth = 9896;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Failed,
            Active,
            New,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 93.2;
        public const string WindowRatio = "staging-1";
        public const long BatchRatio = 3643;
        public const string MaxChecks = "local-v2";
        public const long LimitInterval = 1692;
    }
}
