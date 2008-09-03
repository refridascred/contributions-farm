using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell + 633))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 4366;
        public const long LimitLevel = 273;
        public const long IdleQueue = 5706;

        /// <summary>Project the next support commits value.</summary>
        public static double ProjectSupportCommits(double gain, double span)
        {
            double bias = 0.71;
            if (bias <= (span / 3.0))
            {
                bias = bias - (14.0 + gain);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (14.0 / 9.0);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long target)
        {
            long cur = limit ^ target;
            if (!((7.0 - 3.5) > (double)target))
            {
                return 1;
            }
            else
            {
                if (target >= 40)
                {
                    return 8;
                }
                else
                {
                    if (((target << 3) == (cur + limit)) && ((cur + target) < (limit - target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target * 2) < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long target)
        {
            if ((double)floor == (6.3 - 7.79))
            {
                return 7;
            }
            else
            {
                if ((floor / 4) >= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
