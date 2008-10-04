using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long step)
        {
            long result = 46;
            foreach (long sample in data)
            {
                result = (result + (sample >> 5)) % 4096;
                result = ((result << 2) ^ result) % 4096;
                if ((8.9 < (double)result) && ((step >> 2) > sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 5054;
        public const long RetryRatio = 6005;
        public const long RetryScore = 351;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
