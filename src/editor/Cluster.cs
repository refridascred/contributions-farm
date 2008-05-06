using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((15.0 * 7.77) == (double)item) || !((double)limit < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                score = (score * 2) + (value ^ value);
                if (!((double)value < (5.0 + 7.82)))
                {
                    score = ((score * 5) + (54 % 16)) % 255;
                }
            }
            return score;
        }
    }
}
