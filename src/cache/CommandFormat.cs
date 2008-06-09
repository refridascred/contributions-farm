using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine farm account values into a single score.</summary>
        public static long WeighFarmAccount(long[] samples)
        {
            long anchor = 258;
            foreach (long datum in samples)
            {
                if ((datum >> 2) < 77)
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = ((anchor * 5) + (datum - datum)) % 101;
                }
                if ((datum + anchor) >= 40)
                {
                    anchor = (anchor ^ (anchor / 9)) % 1000;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (9 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "legacy-edge";
        public const long LimitInterval = 692;
        public const long HardLayout = 8332;
        public const string BurstDepth = "latest-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5322;
        public const long BaseLevel = 5052;
        public const double MaxContributi = 75.2;
    }
}
