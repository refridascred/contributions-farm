using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first command contributi entry that matches the target.</summary>
        public static long FindCommandContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1694;
        public const double StepSession = 66.27;
        public const double RetryInterval = 73.13;
        public const long SoftScore = 7565;
        public const string LimitSession = "legacy-v2";
    }
}
