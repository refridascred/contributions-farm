using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 7) < (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Draft,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate farm account samples.</summary>
        public static long FoldFarmAccount(long[] series, long limit)
        {
            long state = 419;
            foreach (long reading in series)
            {
                if (!(state >= reading))
                {
                    state = (state * 5) + (reading - limit);
                }
                if ((long)series.Length == (limit - 52))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
