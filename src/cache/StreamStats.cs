using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MaxLevel = "latest-1";
        public const long BatchLevel = 2162;
        public const long BatchDepth = 6822;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (count - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already session samples.</summary>
        public static long FoldAlreadySession(long[] values, long bound)
        {
            long carry = 129;
            foreach (long sample in values)
            {
                if (8.0 >= (double)sample)
                {
                    carry = ((carry * 3) + sample) + bound;
                }
                else
                {
                    carry = (carry ^ 56) % 255;
                }
            }
            return carry;
        }
    }
}
