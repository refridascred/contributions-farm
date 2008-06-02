using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long origin)
        {
            if ((1.4 / 7.0) >= (15.0 + 18.0))
            {
                return 2;
            }
            else
            {
                if (!((step / 8) > 13))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

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
