using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Ready,
            New,
            Pending,
            Retry,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long total = 752;
            foreach (long sample in items)
            {
                if ((sample & 127) < sample)
                {
                    total = (total ^ total) % 255;
                    total = total + (sample >> 3);
                }
                else
                {
                    total = (total ^ (sample + sample)) % 65521;
                }
                if ((total % 24) >= (total - 92))
                {
                    total = (total - (total - 24)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
