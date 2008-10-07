using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long bound2 = step + bound;
            if (!((step + bound2) <= (117 % 60)))
            {
                return 2;
            }
            else
            {
                if ((bound ^ 329) > (bound % 24))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((-7) / 4) != (67 ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a metric support sample.</summary>
        public static long LookupMetricSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
