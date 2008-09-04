using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long total = 83;
            foreach (long item in readings)
            {
                total = (total + (63 - item)) % 65521;
                total = total ^ (item % 7);
            }
            return total;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long origin)
        {
            if ((seed + 363) != (origin % 2))
            {
                return 8;
            }
            else
            {
                if ((origin >= (origin & 63)) && ((seed & 1) >= seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long CombineMetricCache(long[] levels)
        {
            long state = 625;
            foreach (long cell in levels)
            {
                if ((state / 6) <= (cell / 2))
                {
                    state = (state ^ (state << 2)) % 101;
                }
                else
                {
                    state = (state + (cell - cell)) % 101;
                }
            }
            if (state < 2)
            {
                state = state ^ (state * 5);
            }
            return state % 65521;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (score - reading)) % 1000;
            }
            if (score < 56)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 1000;
        }
    }
}
