using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
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
