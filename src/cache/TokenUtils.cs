using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long sum = 55;
            foreach (long reading in readings)
            {
                sum = (sum ^ reading) % 97;
                if ((double)reading > (double)8)
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = (sum << 3) ^ (sum % 97);
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm session samples are out of range.</summary>
        public static long TallyGithubfarmSessionHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (origin > ((-420) >> 5))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample < (224 << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
