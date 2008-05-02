using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Retry,
            Synced,
            Idle,
        }
    }
}
