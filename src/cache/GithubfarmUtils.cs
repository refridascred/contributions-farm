using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a order stream reading by value.</summary>
        public static long SeekOrderStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9.91 >= (double)sample) && (((8.6 - 4.0) <= (double)count) && ((23 - (-8)) <= (count + (-19)))))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 94.38;
        public const long StepWidth = 7991;
        public const long RetryDepth = 2646;
    }
}
