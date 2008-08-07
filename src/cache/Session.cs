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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + target) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
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
