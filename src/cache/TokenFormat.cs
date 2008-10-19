using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySpan = "stable";
        public const long MinTimeout = 8287;
        public const double BaseFilter = 78.28;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double bias = weight;
            return bias - (weight + span);
        }
    }
}
