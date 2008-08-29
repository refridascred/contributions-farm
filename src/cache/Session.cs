using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - seen) <= (cell * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 3727;
        public const string SoftScore = "fallback-1";
        public const double LimitSpan = 95.84;
        public const long LimitCount = 8989;
    }
}
