using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 6112;
        public const long SoftLayout = 9311;
        public const long MinLayout = 1838;
        public const long RetryLayout = 7307;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 805;
            foreach (long datum in data)
            {
                anchor = (((anchor + (2 + 54)) % 97) ^ datum) - bound;
            }
            return anchor;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
