using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long target)
        {
            long gap = step + target;
            if ((target ^ step) > target)
            {
                return 1;
            }
            else
            {
                if ((step * 2) == (8 + step))
                {
                    return 4;
                }
                else
                {
                    if (gap >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long WeighClusterFormat(long[] samples, long seed)
        {
            long state = 379;
            foreach (long reading in samples)
            {
                state = (((state * 3) + (seed ^ state)) % 4096) + reading;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks metrics readings.</summary>
        public static long MatchChecksMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
