using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Active,
            Ready,
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long ScoreChannelNotes(long[] samples)
        {
            long acc = -95;
            foreach (long value in samples)
            {
                if ((acc > (61 % 10)) && ((double)acc == (1.0 * 8.02)))
                {
                    acc = ((acc - (acc * 5)) % 1000) - value;
                }
            }
            if (acc > 278)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "primary";
        public const long BatchAlready = 3781;
        public const string BurstScore = "strict-1";
        public const long SoftTimeout = 6813;
    }
}
