using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 4032;
        public const long MaxCount = 3966;
        public const long DefaultCount = 5372;
        public const string SoftDepth = "open-1";
        public const long SoftTimeout = 2497;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 95.34;
        public const long RetryCommits = 2776;
        public const long BatchCommits = 9425;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTimeout = 0.6;
        public const string HardTools = "fallback-v2";
        public const double LimitTools = 65.28;
        public const double MaxDepth = 97.4;

        /// <summary>Match up batches channel samples.</summary>
        public static long PairBatchesChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
