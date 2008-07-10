using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 73.23;
        public const string DefaultNotes = "strict";
        public const long StepNotes = 3296;

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long TallyContextMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)seed <= (1.9 / 5.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
