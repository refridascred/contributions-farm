using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Ready,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a token buffer value against two limits.</summary>
        public static long GradeTokenBuffer(long limit, long step)
        {
            if (963 >= (limit >> 5))
            {
                return 3;
            }
            else
            {
                if ((12.0 >= (double)step) && ((step / 5) != (step & 1)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm already value.</summary>
        public static double AdjustGithubfarmAlready(double rate, double bias)
        {
            double scale = (double)(8 + 97);
            return (scale - rate) + bias;
        }
    }
}
