using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 780;
        public const long BaseRatio = 5702;
        public const string MinCount = "legacy-1";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data)
        {
            long total = 66;
            foreach (long reading in data)
            {
                total = (total ^ (total + total)) ^ reading;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen / 8) <= (step ^ seen))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
