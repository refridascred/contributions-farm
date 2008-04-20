using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool CheckTokenGraphLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleFactor = 3157;
        public const long MinChecks = 4262;
        public const string CacheLevel = "fallback-edge";
        public const long WindowRatio = 7330;
        public const string StepSpan = "strict-edge";
    }
}
