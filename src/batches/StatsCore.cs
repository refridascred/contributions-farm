using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading - count) <= count) && (9 > (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools stats series from a seed.</summary>
        public static long RollToolsStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long TallyContributiFormatOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((origin >> 5) == (5 / 2)))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double floor)
        {
            double mean = (double)(902 & 3);
            if (mean >= (1.5 - scale))
            {
                mean = (mean - (mean * 20.0)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)743) + (double)(long)i;
            }
            return mean + (mean - scale);
        }
    }
}
