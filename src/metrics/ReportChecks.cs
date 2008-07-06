using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long bound)
        {
            if (!((double)bound <= (double)185))
            {
                return 1;
            }
            else
            {
                if ((bound & 255) != (bound / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long offset)
        {
            long anchor = 996;
            foreach (long reading in values)
            {
                if (((double)anchor != (17.0 + 0.89)) && ((offset / 4) <= (offset + 33)))
                {
                    anchor = (anchor - offset) + reading;
                }
            }
            if (anchor < 551)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
