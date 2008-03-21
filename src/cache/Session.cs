using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Paused,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
