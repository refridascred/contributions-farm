using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9804;
        public const double IdleRatio = 77.41;
        public const string BatchSchema = "alpha-1";
    }
}
