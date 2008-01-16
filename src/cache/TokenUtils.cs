using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long bound, long seed)
        {
            long next = bound + seed;
            if ((11.0 + 2.81) < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((20.0 / 2.0) != (double)next)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long mix = 233;
            foreach (long cell in levels)
            {
                if ((8.9 < (double)cell) || ((mix + mix) != (cell & 63)))
                {
                    mix = ((mix << 2) ^ (28 - cell)) % 1000;
                }
            }
            return mix;
        }
    }
}
