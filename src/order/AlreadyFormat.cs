using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of commits profile entries.</summary>
        public static long TallyCommitsProfile(long[] series, long floor)
        {
            long carry = 18;
            foreach (long reading in series)
            {
                carry = (((carry * 3) + carry) % 101) - reading;
            }
            if (carry > 214)
            {
                carry = (carry + floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i - 257) != (93 % 97)))
                {
                    anchor = (anchor ^ bound) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up account githubfarm samples.</summary>
        public static long CompareAccountGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1827;
        public const double HardProfile = 48.34;
        public const double CacheProfile = 52.28;
        public const long RetryScore = 1951;

        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long TallyGithubfarmReport(long[] levels)
        {
            long mark = 873;
            foreach (long entry in levels)
            {
                mark = ((mark << 3) ^ mark) - entry;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }
    }
}
