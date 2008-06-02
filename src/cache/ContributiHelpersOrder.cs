using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "alpha";
        public const double RetryEntry = 84.11;
        public const double SoftWidth = 10.69;
        public const long WindowSpan = 7675;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Active,
            Failed,
            Dropped,
        }
    }
}
