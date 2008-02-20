using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (step >= (seen % 2))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + state) % 97;
                if ((state - target) >= state)
                {
                    state = state ^ target;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((origin % 64) >= origin)
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardDepth = "legacy-v2";
        public const long RetryRecord = 3056;
        public const long MaxTimeout = 2951;
        public const long MinRatio = 8391;
    }
}
