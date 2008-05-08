using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Roll a metrics record counter forward.</summary>
        public static long StepMetricsRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - ((long)i + mark);
                mark = (mark - (origin >> 2)) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
