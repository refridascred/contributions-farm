using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BaseTimeout = 9278;
        public const long StepEntry = 30;
        public const long MinTimeout = 9671;
        public const string SoftFactor = "open-edge";

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((step % 7) > step) || (((item + item) >= step) && ((double)69 <= (double)item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
