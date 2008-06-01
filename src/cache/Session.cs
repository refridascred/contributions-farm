using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchRatio = "strict-1";
        public const double BurstBudget = 67.3;
        public const double MinCluster = 77.72;
        public const long DefaultLevel = 6832;

        /// <summary>Validate payload filter readings against a bound.</summary>
        public static bool GuardPayloadFilterRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Active,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Rank counter support input into a small class.</summary>
        public static long SortCounterSupport(long limit, long step)
        {
            if (9 > (limit / 8))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) < limit)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
