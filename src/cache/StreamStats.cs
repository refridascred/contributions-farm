using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1838;
        public const string SoftRoute = "fallback-1";
        public const long IdleSpan = 9261;
        public const long BurstRoute = 7668;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Closed,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
