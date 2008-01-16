using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long MeasureGraphToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches & 255) == (25 + reading))
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

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)target != (7.0 - 4.69)) || (((value * 3) > (57 % 64)) && ((double)value > (14.0 + 2.35))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
