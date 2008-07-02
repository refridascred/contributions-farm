using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits <= (hits + 295)) || ((hits + hits) < (98 ^ 871)))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 485;
            foreach (long reading in data)
            {
                mark = (mark - mark) ^ reading;
            }
            return mark;
        }

        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long CompareMetricsEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
