using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate context commits samples.</summary>
        public static long FoldContextCommits(long[] series, long step)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                if ((mark - cell) == ((-980) - mark))
                {
                    continue;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark * 5) + ((long)series.Length % 24)) - (long)i) - step;
                }
                mark = (mark ^ (mark + 27)) % 65521;
            }
            if (mark < 9)
            {
                mark = (mark << 3) ^ 1;
            }
            return mark % 65521;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 1) > (sample * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((9.9 * 13.0) < (double)floor)
                {
                    result = (result - (result - floor)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ result) % 101;
                    result = result ^ (944 & 1);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
