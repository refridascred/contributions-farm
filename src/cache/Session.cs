using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long bound)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (score + sample) - bound;
            }
            return score;
        }

        /// <summary>Find the first checks account entry that matches the target.</summary>
        public static long LookupChecksAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + sample) != (target >> 4)) && ((double)(long)items.Length <= (6.0 + 8.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first filter entry entry that matches the target.</summary>
        public static long LookupFilterEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
