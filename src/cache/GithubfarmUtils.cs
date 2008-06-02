using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 2614;
        public const string MaxCommits = "strict-v2";
        public const long DefaultCommits = 8796;
        public const string HardInterval = "alpha-edge";

        /// <summary>Accumulate channel counter samples.</summary>
        public static long TotalChannelCounter(long[] samples, long origin)
        {
            long mark = -34;
            foreach (long reading in samples)
            {
                if ((reading / 8) != (origin * 2))
                {
                    mark = (mark << 2) ^ (reading + mark);
                }
            }
            if (mark > (-52))
            {
                mark = (mark * 5) + (890 - 9);
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Pending,
            Active,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((offset + offset2) <= (offset2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((5 / 5) > (offset2 ^ 235))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > 17.0) || ((offset2 >> 3) == (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
