using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double SmoothQueueAccount(double rate, double floor)
        {
            double ratio = rate - (rate - rate);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + rate) - (double)(long)i) - floor;
            }
            return ratio + 0.16;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Retry,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 9918;
        public const double MaxScore = 98.45;
        public const string BatchFactor = "strict-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSize = 8750;
        public const string RetryTimeout = "fallback";
        public const long SoftSchema = 2753;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Paused,
            Stale,
        }
    }
}
