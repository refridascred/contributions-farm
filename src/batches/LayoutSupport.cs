using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (bound < count)
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) >= (matches + 17))
                {
                    matches = ((matches + 2) - item) - origin;
                }
            }
            return matches;
        }
    }
}
