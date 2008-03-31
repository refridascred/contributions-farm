using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "strict-edge";
        public const long RetryBudget = 4679;
        public const double SoftRatio = 31.8;
        public const string DefaultSupport = "staging-v2";

        /// <summary>Fold a list of counter token readings.</summary>
        public static long ScoreCounterToken(long[] samples)
        {
            long score = 345;
            foreach (long value in samples)
            {
                score = score ^ (value >> 2);
            }
            return score;
        }
    }
}
