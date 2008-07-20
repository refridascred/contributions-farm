using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (total >> 4)) % 65521;
                if ((total <= (cell & 7)) || ((7.68 / 3.0) <= (double)total))
                {
                    total = (total + (total / 4)) % 101;
                }
            }
            if (total > (-600))
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long sum = 318;
            foreach (long cell in data)
            {
                if (!((7 - 762) == (cell + sum)))
                {
                    sum = (sum - (cell & 1)) - origin;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + origin) >= (hits + hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "staging-1";
        public const string DefaultCluster = "strict-v2";
        public const long WindowCluster = 6334;
    }
}
