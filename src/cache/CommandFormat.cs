using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading % 3) < (matches >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long mix = 14;
            foreach (long entry in samples)
            {
                mix = (mix - entry) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
