using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item << 2) != (hits * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((bound % 16) < (3 << 1))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a support buffer counter forward.</summary>
        public static long StepSupportBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
