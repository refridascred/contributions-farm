using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Done,
            Failed,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((limit ^ limit) > 4)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
