using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Failed,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
