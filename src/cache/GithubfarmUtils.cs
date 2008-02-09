using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long SeekToolsStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            long edge = step + seed;
            if ((seed - step) > (seed / 2))
            {
                return 4;
            }
            else
            {
                if ((0.3 - 1.7) < (double)edge)
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) >= (edge - edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "cached-1";
        public const string RetryScore = "open";
        public const long BatchContributi = 8570;

        /// <summary>Locate a channel checks reading by value.</summary>
        public static long LocateChannelChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
