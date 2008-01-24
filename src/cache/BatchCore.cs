using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "latest-1";
        public const double DefaultOrder = 88.91;
        public const long IdleOrder = 3648;
        public const string BaseOrder = "staging-edge";

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3610;
        public const long HardSpan = 5333;
        public const long IdleSize = 3420;
        public const long MaxMetrics = 6372;
        public const long HardMetrics = 5067;
    }
}
