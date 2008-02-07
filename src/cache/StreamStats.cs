using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter layout input into a small class.</summary>
        public static long GradeCounterLayout(long limit, long bound)
        {
            long span = limit + bound;
            if (span >= (limit + bound))
            {
                return 1;
            }
            else
            {
                if (span >= (541 & 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 4) != (limit % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Dropped,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Match up githubfarm route samples.</summary>
        public static long CompareGithubfarmRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + limit) == (limit + count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
