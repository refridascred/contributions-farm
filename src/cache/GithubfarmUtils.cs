using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 9793;
        public const long RetrySize = 8945;
        public const long DefaultRatio = 4611;
        public const string MinMetric = "open-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mark = 272;
            foreach (long value in data)
            {
                mark = mark ^ (mark << 1);
                if ((value * 2) <= (offset & 15))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) < (step - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
