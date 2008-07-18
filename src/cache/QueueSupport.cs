using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "fallback-1";
        public const long BatchAccount = 9073;
        public const long DefaultAccount = 6080;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum ^ 504))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
