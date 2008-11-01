using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (216 - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data)
        {
            long acc = 51;
            foreach (long datum in data)
            {
                if (2.7 < (double)acc)
                {
                    acc = acc - (datum << 3);
                }
                else
                {
                    acc = acc - (datum >> 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
