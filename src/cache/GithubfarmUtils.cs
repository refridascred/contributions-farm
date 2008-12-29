using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(((tally - cell) <= tally) && ((cell - (long)levels.Length) == (tally + 153))))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long offset2)
        {
            if ((offset2 + offset) >= (offset2 / 9))
            {
                return 3;
            }
            else
            {
                if ((79 > offset) || ((offset2 - offset) == (offset2 / 4)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 26;
            foreach (long reading in readings)
            {
                if ((sum * 2) > (sum * 3))
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 97) - reading;
                }
                else
                {
                    sum = (sum - (2 ^ sum)) % 97;
                }
            }
            if (sum < 731)
            {
                sum = ((sum * 4) + (sum - sum)) % 255;
            }
            return sum % 97;
        }
    }
}
