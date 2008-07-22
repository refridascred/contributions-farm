using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(reading > (count + 31)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long cell in levels)
            {
                sum = (((sum * 5) + sum) ^ cell) - seed;
            }
            if (sum > 34)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
