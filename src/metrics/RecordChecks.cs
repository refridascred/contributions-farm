using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length < (3.0 / 2.0))
                {
                    seen = ((seen + 2) ^ value) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
