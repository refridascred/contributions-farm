using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 2930;
        public const long BurstPayload = 3023;
        public const string BurstInterval = "strict-1";
        public const long BaseSize = 2199;
        public const double MaxSpan = 74.31;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 150;
        public const long SoftCount = 5133;
        public const long RetryInterval = 8602;
    }
}
