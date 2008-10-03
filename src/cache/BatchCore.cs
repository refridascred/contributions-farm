using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits * 2) >= (cell >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account entry samples.</summary>
        public static long DigestAccountEntry(long[] samples, long step)
        {
            long state = 92;
            foreach (long item in samples)
            {
                if ((599 + 5) == (item - 459))
                {
                    state = (state + (state - step)) % 4096;
                }
                else
                {
                    state = state ^ item;
                    state = (state * 3) + step;
                }
                state = (state + (item + 6)) % 101;
            }
            return state;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin << 2) < (212 + origin))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum << 2) ^ (origin - (long)i)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 6821;
        public const long MinSize = 3969;
        public const double BaseRatio = 52.65;
        public const long SoftEntry = 965;
        public const long SoftScore = 2802;
    }
}
