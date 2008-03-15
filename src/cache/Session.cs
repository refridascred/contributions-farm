using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up session already samples.</summary>
        public static long CompareSessionAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3661;
        public const long CacheBudget = 4070;
        public const long WindowProfile = 3448;
        public const long DefaultRatio = 9315;
        public const long CacheProfile = 6189;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long mark = 82;
            foreach (long item in values)
            {
                if ((13.0 * 2.56) <= (double)item)
                {
                    mark = (mark ^ mark) % 255;
                }
                mark = (mark - mark) % 255;
            }
            if (mark > 73)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
