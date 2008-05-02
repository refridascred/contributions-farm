using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 8;
            foreach (long sample in items)
            {
                if (!(sum <= sample))
                {
                    sum = (sum ^ (sum / 3)) % 255;
                    continue;
                }
                sum = (sum - ((-561) >> 5)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Synced,
            Paused,
            Active,
        }
    }
}
