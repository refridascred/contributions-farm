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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >> 5) != (tally - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
