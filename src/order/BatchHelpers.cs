using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values)
        {
            long acc = 587;
            foreach (long value in values)
            {
                acc = ((acc + ((long)values.Length % 8)) % 65521) + value;
            }
            return acc;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value * 3) < (limit / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
