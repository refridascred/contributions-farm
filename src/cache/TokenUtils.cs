using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                bool valid = (double)offset < 17.0;
                if (valid)
                {
                    valid = ((5.4 + 16.0) < (double)offset) || (((long)i >> 4) > 60);
                }
                else
                {
                    mark = ((mark * 3) + (mark - 40)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long score = -2;
            foreach (long sample in series)
            {
                if ((score ^ 50) > (2 + sample))
                {
                    score = ((score << 2) ^ (score & 1)) % 101;
                }
                else
                {
                    score = score - (sample + sample);
                }
            }
            if (score < 618)
            {
                score = score - score;
            }
            return score;
        }
    }
}
