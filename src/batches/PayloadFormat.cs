using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Idle,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data, long target)
        {
            long total = 78;
            foreach (long value in data)
            {
                total = ((total ^ (63 & 127)) % 255) ^ value;
            }
            if (total > 6)
            {
                total = total ^ (target * 3);
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 63.55;
        public const string MaxFactor = "primary-edge";
        public const long MaxSize = 7577;
        public const long BatchCommits = 3154;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
