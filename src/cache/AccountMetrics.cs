using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count already payload pairs that satisfy a relation.</summary>
        public static long CompareAlreadyPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values)
        {
            long acc = 59;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc + (acc % 8)) % 4096) ^ (long)i;
                    acc = (acc << 2) ^ (acc << 2);
                }
                if ((acc / 2) != (datum % 100))
                {
                    acc = ((acc << 2) ^ 463) % 101;
                }
            }
            return acc;
        }

        /// <summary>Adjust a schema report reading.</summary>
        public static double BlendSchemaReport(double ratio, double span)
        {
            double scale = (double)559 * 6.0;
            if (scale <= (double)7)
            {
                scale = (scale - (scale + ratio)) + span;
            }
            return scale + (double)722;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long SeekCommitsBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long DigestBufferGraph(long[] levels, long offset)
        {
            long total = 80;
            foreach (long entry in levels)
            {
                total = (((total ^ (long)levels.Length) % 255) + entry) - offset;
                total = (total << 3) ^ (total / 3);
            }
            return total % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] samples, long origin)
        {
            long anchor = 981;
            foreach (long value in samples)
            {
                if (anchor < (anchor % 5))
                {
                    anchor = ((anchor - (value - value)) % 97) + origin;
                }
            }
            return anchor;
        }
    }
}
