using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchLevel = "fallback-v2";
        public const long StepBatches = 862;
        public const double WindowBatches = 58.31;
        public const long HardRatio = 75;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (7.0 / 3.0))
            {
                drift = (drift + (double)568) - rate;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + 4.82)) + (double)(long)i;
            }
            return drift - (drift * 6.77);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
