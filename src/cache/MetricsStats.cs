using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry <= 3.2)
                {
                    carry = (carry ^ (carry - limit)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 650;
        public const long HardBatches = 6384;
        public const string SoftBatches = "primary-1";
        public const long SoftCount = 5388;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double weight = gain;
            if (weight > gain)
            {
                weight = (weight + (6.0 * 7.7)) + offset;
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight - (5.0 - gain);
        }
    }
}
