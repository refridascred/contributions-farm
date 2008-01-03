using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Locked,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Scale a record metrics figure with a bias.</summary>
        public static double ScaleRecordMetrics(double gain, double offset)
        {
            double rate = 10.0;
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate - 8.0) + (double)(long)i) + gain) + offset;
            }
            return rate - (double)5;
        }
    }
}
