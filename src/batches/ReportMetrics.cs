using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long score = 615;
            foreach (long item in readings)
            {
                score = (score << 3) ^ item;
                if (!((66 + score) < (item % 24)))
                {
                    score = score ^ (item & 127);
                }
            }
            return score % 1000;
        }
    }
}
