using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - limit) < (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long origin)
        {
            long mark = 859;
            foreach (long value in items)
            {
                mark = (((mark << 3) ^ (mark & 3)) + value) + origin;
            }
            if (mark > 62)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a batches command sample.</summary>
        public static long LookupBatchesCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long step2)
        {
            if ((double)1 <= (double)step2)
            {
                return 2;
            }
            else
            {
                if (step >= step2)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
