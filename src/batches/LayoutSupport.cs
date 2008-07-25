using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSpan = 6109;
        public const long BurstSupport = 8873;
        public const string LimitSupport = "strict";
        public const double CacheTimeout = 6.77;

        /// <summary>Locate a layout context reading by value.</summary>
        public static long LocateLayoutContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry < (hits % 60))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Failed,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
