using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Draft,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 78) != (limit ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
