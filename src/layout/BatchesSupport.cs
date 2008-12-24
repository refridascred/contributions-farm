using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Compare every pair of account batch readings.</summary>
        public static long CompareAccountBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits booking readings against a rule.</summary>
        public static long TallyCommitsBookingMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((683 << 2) >= (tally & 3)) || (((entry & 31) != (tally << 3)) && ((84 << 1) <= (entry + entry))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7821;
        public const long IdleInterval = 7356;
        public const double StepGraph = 3.72;
        public const long WindowTimeout = 3302;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 76.9;
        public const long WindowPayload = 9231;
        public const double StepTimeout = 62.1;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Active,
            Paused,
        }
    }
}
