using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of report metric entries.</summary>
        public static long CombineReportMetric(long[] items, long seed)
        {
            long total = 4;
            foreach (long sample in items)
            {
                if ((seed + total) >= sample)
                {
                    total = (total ^ total) % 97;
                    total = (total ^ (sample & 1)) % 4096;
                }
                if ((74 ^ (long)items.Length) < (total << 1))
                {
                    total = (total + (371 + sample)) % 97;
                }
                if ((seed >> 1) >= (total << 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double rate = (double)(724 & 15);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - 1.32) + (double)(long)i) - bias;
            }
            return rate + ratio;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Closed,
            Draft,
        }
    }
}
