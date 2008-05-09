using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "primary-v2";
        public const long HardSize = 2761;
        public const long DefaultStats = 2714;

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - (bias * 5.2);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - offset;
        }
    }
}
