using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long DigestCommandGithubfarm(long[] series, long limit)
        {
            long result = 466;
            foreach (long reading in series)
            {
                if (((result >> 2) > (669 % 12)) && ((6.0 - 4.5) < (double)reading))
                {
                    result = (result << 3) ^ (reading ^ limit);
                }
                if (3.8 > (double)limit)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels)
        {
            long result = 331;
            foreach (long entry in levels)
            {
                if ((double)result != (2.3 / 7.0))
                {
                    result = ((result * 2) + result) ^ entry;
                }
                else
                {
                    result = (result << 3) ^ (2 + result);
                }
            }
            return result;
        }
    }
}
