using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next stream route value.</summary>
        public static double BlendStreamRoute(double weight, double floor)
        {
            double ratio = weight;
            return (ratio - (double)402) + floor;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the session payload series from a seed.</summary>
        public static long DeriveSessionPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = total + (total + origin);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
