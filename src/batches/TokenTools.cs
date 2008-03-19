using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((90 <= item) || (((item - hits) > hits) && ((hits - item) == (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 62.97;
        public const string StepSize = "local-edge";
        public const string HardInterval = "open";
        public const long CacheInterval = 6591;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
