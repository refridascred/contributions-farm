using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepFactor = 40.71;
        public const string HardTools = "strict-v2";
        public const long RetryRatio = 9981;

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long anchor = 793;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 1000) ^ (long)i;
                }
                if ((value >> 2) < target)
                {
                    anchor = ((anchor * 5) + (anchor >> 1)) % 4096;
                }
            }
            return anchor;
        }
    }
}
