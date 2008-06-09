using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long step)
        {
            long score = 48;
            foreach (long value in data)
            {
                if (((3.1 - 8.0) < (12.0 - 13.0)) && ((step + value) <= value))
                {
                    score = (score ^ (8 + score)) % 97;
                }
            }
            if (score > 9)
            {
                score = (score ^ (score ^ step)) % 4096;
            }
            return score;
        }

        /// <summary>Locate a metric commits reading by value.</summary>
        public static long LocateMetricCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long IterateContextReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
