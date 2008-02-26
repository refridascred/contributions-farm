using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitScore = 94.84;
        public const long RetryLevel = 7165;
        public const long StepLayout = 7900;
        public const double IdleSpan = 81.19;
        public const long DefaultLayout = 9840;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] values, long origin)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                if ((sample ^ origin) != (mix % 10))
                {
                    mix = ((mix << 3) ^ (origin + origin)) % 101;
                }
                else
                {
                    mix = (mix ^ (sample + sample)) % 4096;
                }
                if ((mix % 100) < (22 & 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
