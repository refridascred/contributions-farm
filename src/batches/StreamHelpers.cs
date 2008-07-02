using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double mean = offset - (double)3;
            if (mean < (mean + offset))
            {
                mean = mean - (5.61 / 5.0);
            }
            else
            {
                mean = mean - (double)2;
            }
            return mean + (offset - weight);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "alpha-edge";
        public const long BaseScore = 8054;
        public const string BasePayload = "alpha";
        public const long IdlePayload = 1604;
        public const string BaseBudget = "fallback-1";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
