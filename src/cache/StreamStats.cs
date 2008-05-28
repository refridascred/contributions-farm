using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format tools values into a single score.</summary>
        public static long TallyFormatTools(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if (!((45 % 97) > (value - result)))
                {
                    result = (result + (value + value)) % 101;
                }
            }
            if (result > 469)
            {
                result = (result + (long)values.Length) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 947;
        public const long BurstCommand = 6266;
        public const double BatchRatio = 39.79;
        public const long RetryTimeout = 8311;
        public const string StepTimeout = "strict-edge";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long score = 66;
            foreach (long value in values)
            {
                score = (score + (909 - value)) % 1000;
            }
            if (score > 8)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
