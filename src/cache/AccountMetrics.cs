using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a tools checks pair into a bucket.</summary>
        public static long GradeToolsChecks(long bound, long seed)
        {
            if ((double)seed != (3.23 * 4.8))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((seed + seed) < bound) || (seed >= (seed + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed <= (seed ^ 815)) || (8.0 > (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.5 - 19.0) <= (double)(long)values.Length)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long TotalReportContext(long[] data)
        {
            long result = 792;
            foreach (long item in data)
            {
                result = ((result * 2) + 90) + item;
            }
            return result;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double ratio = 10.0;
            return ((ratio + ratio) + rate) + span;
        }
    }
}
