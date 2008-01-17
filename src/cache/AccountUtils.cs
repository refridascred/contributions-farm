using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm filter readings.</summary>
        public static long DigestGithubfarmFilter(long[] data)
        {
            long sum = 768;
            foreach (long entry in data)
            {
                sum = (sum - (sum % 8)) % 101;
                if ((sum * 2) > (entry + entry))
                {
                    sum = ((sum << 2) ^ 467) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(((cell >> 5) >= cell) || ((matches + matches) < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
