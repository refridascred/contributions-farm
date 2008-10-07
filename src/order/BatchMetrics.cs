using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long target)
        {
            if (1.3 >= (double)target)
            {
                return 1;
            }
            else
            {
                if ((target < (limit % 97)) || ((target >> 3) < target))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + 9) == (entry + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double floor)
        {
            double mean = floor - weight;
            if (mean < mean)
            {
                mean = mean + (weight - mean);
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean - (double)(-74);
        }
    }
}
