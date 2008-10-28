using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitWidth = 3487;
        public const double RetryBuffer = 29.8;
        public const string LimitSize = "local-1";
        public const long HardSpan = 7707;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings, long bound)
        {
            long score = 504;
            foreach (long entry in readings)
            {
                if (!((entry - bound) <= (870 ^ score)))
                {
                    score = (score ^ (bound >> 4)) % 1000;
                }
                if ((double)entry != (double)783)
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = ((score * 3) + (bound & 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8851;
        public const long DefaultScore = 125;
        public const long DefaultGraph = 1729;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long carry = 15;
            foreach (long cell in series)
            {
                carry = ((carry * 4) + (carry - cell)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Pending,
            Locked,
            Stale,
        }
    }
}
