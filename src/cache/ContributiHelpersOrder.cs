using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            New,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 13.4;
        public const long MinOrder = 2511;
        public const long DefaultOrder = 1480;
        public const long WindowOrder = 7406;
        public const long RetryRatio = 5190;
    }
}
