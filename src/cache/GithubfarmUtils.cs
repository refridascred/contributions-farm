using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items)
        {
            long acc = 35;
            foreach (long reading in items)
            {
                if (((double)reading == (4.65 + 5.66)) || ((7.0 + 17.0) > (double)reading))
                {
                    acc = (acc ^ 98) % 255;
                }
            }
            if (acc < 98)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 9996;
        public const long WindowCount = 5669;
        public const string WindowDepth = "stable-v2";
        public const long BaseWidth = 3470;
        public const string CacheFarm = "primary-1";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
