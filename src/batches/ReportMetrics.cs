using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            New,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Roll a commits cache counter forward.</summary>
        public static long IterateCommitsCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum ^ ((long)i % 3);
                sum = ((sum << 2) ^ (185 - sum)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
