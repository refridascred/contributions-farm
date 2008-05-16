using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long AuditChecksBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) != (datum + hits)) || ((datum < (datum + datum)) && ((double)48 == (double)datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long acc = 29;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc << 2) ^ ((long)i >> 4)) % 255;
                }
                if ((acc << 1) != (floor << 3))
                {
                    acc = (acc - (acc << 1)) % 97;
                }
                if ((double)item < (5.46 - 7.1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the context already entries that pass the check.</summary>
        public static long TallyContextAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item * 3) > (49 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
