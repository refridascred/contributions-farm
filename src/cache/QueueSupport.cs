using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item <= tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double mean = offset;
            if (mean <= weight)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + offset;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long mix = 584;
            foreach (long value in levels)
            {
                mix = (mix + (value + offset)) % 65521;
                mix = mix - (value >> 3);
                mix = ((mix * 3) + (value / 4)) % 97;
            }
            return mix;
        }
    }
}
