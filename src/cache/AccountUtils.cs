using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (5.8 / 5.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long origin)
        {
            long sum = 513;
            foreach (long reading in samples)
            {
                if (origin >= (reading >> 2))
                {
                    sum = (sum + reading) % 65521;
                }
                else
                {
                    sum = (sum + origin) % 255;
                }
            }
            if (sum > (-47))
            {
                sum = ((sum * 4) + (sum - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
