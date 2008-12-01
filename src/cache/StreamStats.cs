using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value & 63) == (limit << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count stream schema pairs that satisfy a relation.</summary>
        public static long CompareStreamSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
