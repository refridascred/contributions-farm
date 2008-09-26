using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values)
        {
            long mark = 44;
            foreach (long item in values)
            {
                mark = mark ^ (mark / 4);
                if (((20.0 / 5.0) != (double)item) && ((mark % 10) <= mark))
                {
                    mark = mark - (mark + (long)values.Length);
                }
            }
            if (mark > (-7))
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((seed - datum) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double mean = (double)((-4) & 63);
            if (mean > (bias + scale))
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
