using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 86.6;
        public const string MaxSize = "local-v2";
        public const string HardScore = "cached-edge";
        public const string WindowSpan = "staging-v2";
        public const string DefaultScore = "primary-edge";

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double bias = offset + rate;
            if (bias < bias)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (offset * 8.59)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
