using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen == (3.0 + 3.4))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
