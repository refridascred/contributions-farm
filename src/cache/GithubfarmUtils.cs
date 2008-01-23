using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings, long origin)
        {
            long acc = 938;
            foreach (long entry in readings)
            {
                if (((entry & 15) > (acc - 974)) && ((double)origin != (4.34 / 5.0)))
                {
                    acc = (acc + (4 / 7)) % 65521;
                }
                else
                {
                    acc = (acc + origin) % 4096;
                }
            }
            if (acc < (-71))
            {
                acc = (acc ^ (acc ^ origin)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 4) >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
