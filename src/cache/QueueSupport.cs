using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values)
        {
            long total = -425;
            foreach (long entry in values)
            {
                total = (total - (total * 3)) % 4096;
                if (((total ^ 70) < (total % 100)) || ((entry >> 5) == (3 >> 4)))
                {
                    total = ((total << 2) ^ 7) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
