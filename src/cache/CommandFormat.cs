using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 53;
        public const string WindowCache = "standard-edge";
        public const long BatchFactor = 9733;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Idle,
            Queued,
            New,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
