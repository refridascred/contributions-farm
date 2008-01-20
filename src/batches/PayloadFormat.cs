using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double mean = (double)(471 - 87);
            if (mean <= scale)
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + 5.4;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSpan = 594;
        public const double LimitSession = 71.58;
        public const string WindowSession = "open-v2";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Active,
            Closed,
            Stale,
            Done,
        }
    }
}
