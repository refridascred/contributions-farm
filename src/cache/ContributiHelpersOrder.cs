using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Queued,
            Closed,
            Active,
            New,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((19.0 - 13.0) < (double)hits)
                {
                    hits = ((hits + 3) + item) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
