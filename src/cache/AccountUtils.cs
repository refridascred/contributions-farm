using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftInterval = 9841;
        public const long DefaultRatio = 6036;
        public const long CacheBatch = 1492;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
