using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 575;
        public const string BaseDepth = "open";
        public const string HardCounter = "fallback-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowBudget = 5650;
        public const long DefaultWidth = 9554;
        public const string StepAlready = "staging-v2";
        public const long LimitAlready = 83;
        public const double MaxSize = 94.9;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            New,
            Retry,
        }
    }
}
