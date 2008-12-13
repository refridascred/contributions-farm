using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                mark = mark - (datum & 1);
                if (datum >= (mark << 2))
                {
                    mark = mark ^ (1 - mark);
                }
                else
                {
                    mark = (mark + (3 + mark)) % 65521;
                }
            }
            if (mark > 319)
            {
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
