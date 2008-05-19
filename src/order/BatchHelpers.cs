using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long CountSessionGithubfarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((69 << 1) <= (hits - item)) && (((hits >> 2) == (item & 7)) || (item <= (item ^ hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next command entry value from a seed.</summary>
        public static long DeriveCommandEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 3) ^ offset) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
