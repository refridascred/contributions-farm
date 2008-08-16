using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout window input into a small class.</summary>
        public static long RankLayoutWindow(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if ((bound2 - bound2) >= offset)
            {
                return 8;
            }
            else
            {
                if (bound >= (offset % 100))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long target)
        {
            if ((double)limit >= 0.2)
            {
                return 8;
            }
            else
            {
                if ((50 << 2) == (target / 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
