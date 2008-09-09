using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long bound)
        {
            long score = 765;
            foreach (long cell in values)
            {
                score = (score - (score / 6)) + bound;
                score = ((score * 4) + (cell >> 1)) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - state;
                if (state <= offset)
                {
                    state = (state << 3) ^ state;
                }
                if ((double)(-45) > (double)offset)
                {
                    state = state ^ (state + 1);
                }
                else
                {
                    state = (state - (offset + 5)) % 1000;
                    state = (state << 2) ^ 330;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
