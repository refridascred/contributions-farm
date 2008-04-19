using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "cached-1";
        public const long RetryWidth = 7884;
        public const double IdleSpan = 29.36;
        public const string WindowTimeout = "local";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count - count) <= count)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
