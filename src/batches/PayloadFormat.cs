using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 3) ^ acc;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) != (59 % 2))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
