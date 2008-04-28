using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound + acc) <= (bound << 3))
                {
                    acc = acc - (bound - acc);
                    acc = (acc ^ (28 ^ 75)) % 97;
                }
                else
                {
                    acc = (acc - (0 + bound)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long step)
        {
            long mark = 77;
            foreach (long value in values)
            {
                mark = (mark ^ (step + 6)) ^ value;
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Active,
            Stale,
            New,
        }
    }
}
