using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2295;
        public const long IdleCluster = 663;
        public const long LimitCount = 6118;
        public const long StepCluster = 9855;
        public const string BaseSpan = "open-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen >= (2 % 24))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 3532;
        public const long BatchTimeout = 621;
        public const string CacheRatio = "fallback-edge";
        public const long StepSpan = 9969;
        public const long SoftScore = 2060;
    }
}
