using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double weight = gain;
            if (weight >= (floor + gain))
            {
                weight = weight + (double)46;
            }
            else
            {
                weight = weight + (floor / 7.0);
            }
            return weight + floor;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9453;
        public const string LimitReport = "primary-v2";
        public const long MaxScore = 6381;
    }
}
