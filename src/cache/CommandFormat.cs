using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            New,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-v2";
        public const string StepFarm = "stable";
        public const long RetryFarm = 8642;
        public const long LimitWidth = 7763;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double bias2 = rate * 2.2;
            if (bias2 > (double)(-12))
            {
                bias2 = bias2 + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
