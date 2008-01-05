using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a stats layout counter forward.</summary>
        public static long SeriesStatsLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (long)i) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((46 % 97) >= matches)
                {
                    matches = ((matches + 1) + sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi tools values into a single score.</summary>
        public static long TotalContributiTools(long[] samples)
        {
            long state = 152;
            foreach (long item in samples)
            {
                if ((item + 38) == (item << 1))
                {
                    state = (state - (state >> 2)) % 65521;
                }
                else
                {
                    state = (state + (item + item)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
