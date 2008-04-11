using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long bound)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                state = ((state + 43) ^ cell) - bound;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (9.0 + 4.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + seen) <= step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
