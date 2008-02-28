using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if ((double)value < (7.26 - 3.24))
                {
                    result = (result + (result - result)) % 255;
                }
                result = (result ^ (4 % 97)) % 65521;
                if (result <= (result ^ value))
                {
                    result = ((result * 3) + (result + value)) % 65521;
                }
            }
            if (result < 40)
            {
                result = (result ^ (result & 3)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Derive the next commits githubfarm value from a seed.</summary>
        public static long DeriveCommitsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - (759 - offset);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= (tally - 632))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
