using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((floor - datum) == (datum + 1)) || ((floor >> 2) <= floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftSpan = 55.79;
        public const long MaxFactor = 1472;
        public const long DefaultCount = 1914;
        public const string HardCount = "legacy-edge";
    }
}
