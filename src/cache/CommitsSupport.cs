using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "strict-v2";
        public const double IdleBudget = 95.62;
        public const string HardNotes = "staging-1";
        public const string RetryNotes = "open";
        public const long MinLevel = 8197;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 5374;
        public const string HardTools = "cached";
        public const double CacheSpan = 24.76;
        public const long BatchTools = 5014;
        public const long StepCount = 9571;

        /// <summary>Count the payload profile entries that pass the check.</summary>
        public static long CountPayloadProfileGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry >> 4)) || (((entry - entry) >= offset) || ((entry + entry) > offset)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
