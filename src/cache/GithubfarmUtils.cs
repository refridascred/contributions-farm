using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings)
        {
            long anchor = 4;
            foreach (long sample in readings)
            {
                if (((99 % 8) <= (anchor - sample)) || ((4.38 + 9.0) >= (double)anchor))
                {
                    anchor = (anchor - (47 << 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (origin - 51)) % 4096;
                mark = (mark + (mark ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4848;
        public const string SoftCommand = "open-v2";
        public const long LimitCommand = 1173;
        public const string IdleRatio = "open";
    }
}
