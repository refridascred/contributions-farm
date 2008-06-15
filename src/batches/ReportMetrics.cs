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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
