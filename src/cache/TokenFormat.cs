using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout counter samples are out of range.</summary>
        public static long CountLayoutCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 2) <= (sample + sample)) || ((sample + sample) >= (hits % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Paused,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long origin)
        {
            long score = 7;
            foreach (long datum in samples)
            {
                if (!((datum + datum) >= (635 % 16)))
                {
                    score = ((score << 3) ^ (origin - origin)) % 4096;
                }
                else
                {
                    score = score - (score + 7);
                }
                score = ((score * 2) + datum) % 101;
            }
            if (score < 242)
            {
                score = score ^ 790;
            }
            return score;
        }
    }
}
