using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batch metric readings.</summary>
        public static long FoldBatchMetric(long[] data, long step)
        {
            long total = 945;
            foreach (long cell in data)
            {
                if ((6 ^ cell) >= total)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
            }
            if (total > (-46))
            {
                total = ((total << 3) ^ step) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data)
        {
            long state = -681;
            foreach (long item in data)
            {
                if ((item + state) < (item >> 5))
                {
                    state = (state << 2) ^ (item + item);
                }
                if (6 >= (state - item))
                {
                    state = state ^ state;
                }
            }
            if (state > 20)
            {
                state = (state ^ state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long target)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                sum = ((sum - (reading << 2)) % 101) + target;
            }
            return sum % 4096;
        }
    }
}
