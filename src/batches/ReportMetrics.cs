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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mix = 37;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ cell) % 101;
            }
            if (mix < (-1))
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix % 65521;
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
