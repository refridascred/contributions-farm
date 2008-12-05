using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double mean = (double)228 / 9.0;
            return ((mean + (double)38) + rate) + floor;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
