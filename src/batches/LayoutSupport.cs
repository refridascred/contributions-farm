using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BurstLayout = 8922;
        public const long MaxSpan = 2869;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            long next = step ^ limit;
            if (next >= (44 % 3))
            {
                return 4;
            }
            else
            {
                if ((next - limit) <= (limit + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 5844;
        public const long MaxCounter = 5658;
        public const long BatchDepth = 1239;
        public const long SoftScore = 8871;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (4 > (reading >> 4))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
