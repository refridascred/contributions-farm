using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Paused,
            Draft,
            New,
        }
    }
}
