using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long limit, long step)
        {
            if ((9 >> 4) < (limit & 15))
            {
                return 7;
            }
            else
            {
                if ((740 < (4 + step)) && ((step + step) != (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Failed,
            Synced,
            Dropped,
        }
    }
}
