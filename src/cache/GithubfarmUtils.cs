using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long origin)
        {
            if ((3 % 64) >= (origin ^ bound))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + origin) >= (bound ^ 500)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long acc = 1;
            foreach (long item in values)
            {
                acc = (acc + (item & 1)) % 1000;
                acc = (acc << 2) ^ 8;
                if (item <= (5 << 2))
                {
                    acc = (acc << 3) ^ (acc % 60);
                }
            }
            if (acc < (-28))
            {
                acc = (acc ^ (acc << 2)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardScore = 927;
        public const string MaxLevel = "fallback-edge";
        public const long WindowTools = 4770;
        public const string LimitTools = "primary-1";
        public const string IdleFactor = "stable-1";
    }
}
