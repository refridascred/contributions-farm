using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long origin)
        {
            long sum = -34;
            foreach (long datum in data)
            {
                if (((long)data.Length != (origin >> 2)) && ((double)sum < (double)1))
                {
                    sum = ((sum + (528 % 64)) % 101) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (5 <= hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
