using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (14.0 - 5.3))
                {
                    count = ((count + 2) + sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long AuditBatchSupportGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((2.2 / 5.0) >= (double)count)
                {
                    count = ((count + 3) ^ reading) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((533 > (tally >> 5)) && ((datum + 4) != (793 - tally)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
