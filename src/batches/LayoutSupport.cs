using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 42.63;
        public const double WindowFactor = 69.01;
        public const long BaseSize = 667;
        public const double IdleSize = 37.32;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits << 1) == ((long)series.Length + 6))
                {
                    hits = ((hits + 3) + reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
