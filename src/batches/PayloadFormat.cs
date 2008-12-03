using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + seen) <= (seen % 8))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (0.44 <= (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile farm readings.</summary>
        public static long CombineProfileFarm(long[] samples)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                if ((double)sum == (0.8 / 9.0))
                {
                    sum = sum - (item - 14);
                }
            }
            if (sum < 88)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Find the first record profile entry that matches the target.</summary>
        public static long LocateRecordProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
