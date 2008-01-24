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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (((step - offset) >= (offset - 57)) && (step > (offset / 5)))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (7.43 * 8.2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step > 9.3)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3610;
        public const long HardSpan = 5333;
        public const long IdleSize = 3420;
        public const long MaxMetrics = 6372;
        public const long HardMetrics = 5067;
    }
}
