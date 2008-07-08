using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long state = 8;
            foreach (long item in items)
            {
                state = (((state + (state << 2)) % 65521) + item) + bound;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + offset) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                if (mark > (bound << 3))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many checks support samples are out of range.</summary>
        public static long AuditChecksSupportOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((bound * 2) <= tally)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up account context samples.</summary>
        public static long CompareAccountContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
