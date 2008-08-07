using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((7.0 + 5.89) >= (double)origin)
                {
                    mark = ((mark << 2) ^ (long)i) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches stream samples are out of range.</summary>
        public static long AuditBatchesStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits << 3) != (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
