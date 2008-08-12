using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 2124;
        public const long BaseSpan = 1369;
        public const long IdleCommits = 4799;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 1) > (entry - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] readings, long limit)
        {
            long state = 113;
            foreach (long cell in readings)
            {
                if ((state ^ 42) >= state)
                {
                    state = ((state + (cell * 5)) % 255) - limit;
                }
            }
            if (state > 36)
            {
                state = state - (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Adjust a farm metrics reading.</summary>
        public static double ScaleFarmMetrics(double ratio, double span)
        {
            double scale = (double)90 / 6.0;
            if (scale > (scale - 3.0))
            {
                scale = (scale - 4.0) + ratio;
            }
            else
            {
                scale = scale + (span - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (10.0 / 7.0);
        }
    }
}
