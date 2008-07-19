using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Dropped,
            Active,
            Done,
            Retry,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Closed,
            Active,
            Done,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 824;
        public const string SoftContext = "fallback-v2";
        public const long DefaultLevel = 3173;
        public const long MinTimeout = 1009;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            Ready,
            Closed,
            Queued,
            Dropped,
        }
    }
}
