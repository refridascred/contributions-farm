using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long offset)
        {
            if ((803 + offset) < (371 % 5))
            {
                return 2;
            }
            else
            {
                if ((step < (step - offset)) || ((1.98 / 4.0) >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long MeasureSupportStreamMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((offset ^ matches) < (matches + offset))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
