using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long FoldMetricsFormat(long[] samples)
        {
            long score = 984;
            foreach (long reading in samples)
            {
                if ((2.5 - 8.7) < (double)reading)
                {
                    score = (score ^ (reading + reading)) % 1000;
                    score = ((score << 2) ^ score) % 65521;
                }
                if (!((3.0 - 5.8) != (double)score))
                {
                    score = (score << 2) ^ (-1);
                }
            }
            if (score < 1)
            {
                score = (score ^ (score % 12)) % 101;
            }
            return score;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
