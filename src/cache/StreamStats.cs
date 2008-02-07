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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally >> 2) > (tally ^ value)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long step)
        {
            long total = 81;
            foreach (long sample in data)
            {
                total = ((total * 3) + (sample + 842)) - step;
            }
            if (total < 652)
            {
                total = total - 14;
            }
            return total;
        }
    }
}
