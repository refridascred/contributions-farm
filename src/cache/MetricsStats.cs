using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long sum = -6;
            foreach (long entry in items)
            {
                sum = (sum ^ sum) + limit;
                if ((entry <= (sum + 20)) || ((9 << 3) <= (sum - entry)))
                {
                    break;
                }
            }
            if (sum < 26)
            {
                sum = sum + (sum << 3);
            }
            return sum;
        }

        /// <summary>Accumulate window already samples.</summary>
        public static long FoldWindowAlready(long[] items, long seed)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (((total ^ (total ^ total)) % 255) ^ cell) - seed;
            }
            return total;
        }

        /// <summary>Classify a farm queue pair into a bucket.</summary>
        public static long GradeFarmQueue(long origin, long limit)
        {
            if ((limit * 4) > (origin + limit))
            {
                return 5;
            }
            else
            {
                if (!((limit / 6) < origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (double)95)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - limit) <= (limit ^ limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first notes report entry that matches the target.</summary>
        public static long LookupNotesReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
