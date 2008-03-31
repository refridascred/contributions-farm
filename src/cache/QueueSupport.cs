using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
