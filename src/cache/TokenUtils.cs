using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample / 5) > (count + sample)) || ((539 + sample) > sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 35.0;
        public const long RetryFactor = 6998;
        public const string WindowCounter = "latest-v2";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
