using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (1.0 * 5.7))
                {
                    sum = (sum - entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i >= ((-89) & 31)) && (mark > (origin + (long)i)))
                {
                    mark = mark ^ (long)i;
                    mark = ((mark << 3) ^ (origin / 2)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
