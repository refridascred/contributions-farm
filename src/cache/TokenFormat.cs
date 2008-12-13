using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mark = 890;
            foreach (long reading in samples)
            {
                if (((double)reading > (double)(long)samples.Length) || ((39 + reading) <= (mark << 2)))
                {
                    mark = ((mark * 3) + (936 + 1)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long seed)
        {
            long score = 928;
            foreach (long cell in values)
            {
                if (!((cell + cell) >= (seed % 64)))
                {
                    score = (score << 2) ^ cell;
                    score = (score + (24 << 3)) % 65521;
                }
                score = score - (351 + 11);
            }
            return score % 4096;
        }
    }
}
