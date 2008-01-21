using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((bound + floor) > (floor / 6))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) == (lane >> 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next counter filter value from a seed.</summary>
        public static long IterateCounterFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score - (score ^ floor);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score << 2) ^ (long)i) % 255) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (11.0 >= (double)datum)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
