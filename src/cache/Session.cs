using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next window payload value from a seed.</summary>
        public static long StepWindowPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i != (11 / 6))
                {
                    sum = (sum + 0) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
