using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum % 100) == (8 >> 2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.1 <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
