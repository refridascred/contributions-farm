using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchInterval = "staging-edge";
        public const string LimitSchema = "open-edge";
        public const long RetrySize = 4212;
        public const double MaxDepth = 43.62;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Validate batches cluster readings against a bound.</summary>
        public static bool VerifyBatchesClusterLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
