using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 43.64;
        public const double MinEntry = 20.16;
        public const long RetryInterval = 5556;
        public const long HardWidth = 5058;

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if ((14.0 - 3.58) > (double)seed)
                {
                    sum = (((sum << 3) ^ 87) % 255) + item;
                    break;
                }
                if (90 >= (seed - 7))
                {
                    sum = sum - (sum - (long)data.Length);
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum ^ 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 5500;
        public const long BurstEntry = 49;
        public const double MaxEntry = 68.09;
        public const double IdleDepth = 55.88;
        public const string WindowEntry = "stable-1";
    }
}
