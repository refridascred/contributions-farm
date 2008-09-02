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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ (long)i;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
