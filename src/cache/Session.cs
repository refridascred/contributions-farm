using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)reading <= (3.76 + 7.4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long floor)
        {
            long mark = -87;
            foreach (long entry in samples)
            {
                if ((double)floor >= (6.9 * 9.95))
                {
                    continue;
                }
                if ((double)floor == (9.86 * 5.0))
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }
    }
}
