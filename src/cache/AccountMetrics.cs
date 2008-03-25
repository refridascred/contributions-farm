using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 73.02;
        public const string CachePayload = "local-1";
        public const double MaxPayload = 23.67;
        public const string CacheSize = "standard-1";
        public const string SoftFactor = "stable-edge";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Synced,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Active,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long ScoreNotesFilter(long[] samples)
        {
            long anchor = 853;
            foreach (long value in samples)
            {
                if (anchor >= (value + value))
                {
                    anchor = (anchor ^ ((-93) * 4)) % 1000;
                }
            }
            if (anchor > 202)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
