using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum / 3) == (datum * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "local-edge";
        public const string BatchInterval = "open-v2";
        public const long WindowContext = 2672;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Pending,
            Idle,
            Draft,
        }
    }
}
