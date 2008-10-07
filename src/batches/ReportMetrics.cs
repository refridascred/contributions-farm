using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long acc = -56;
            foreach (long entry in values)
            {
                if ((target + target) < entry)
                {
                    acc = ((acc << 3) ^ 0) % 97;
                }
                if ((target % 12) != (534 - acc))
                {
                    acc = (acc << 2) ^ (acc - entry);
                }
                else
                {
                    acc = (acc ^ (entry ^ acc)) % 101;
                }
            }
            if (acc < (-4))
            {
                acc = (acc * 5) + 5;
            }
            return acc;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
