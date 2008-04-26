using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats editor readings.</summary>
        public static long ScoreStatsEditor(long[] values)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (((item + item) > ((long)values.Length & 255)) && (total < (total & 31)))
                {
                    total = (total ^ (37 ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long floor)
        {
            long mark = 691;
            foreach (long entry in readings)
            {
                mark = (((mark - (mark + (-938))) % 1000) ^ entry) - floor;
                mark = (mark - (mark + 43)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Closed,
            Ready,
            Queued,
            Paused,
        }
    }
}
