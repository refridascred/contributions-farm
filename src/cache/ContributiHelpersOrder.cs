using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long seed)
        {
            long sum = 45;
            foreach (long value in values)
            {
                if ((22 + seed) == (value + sum))
                {
                    sum = (sum ^ (sum << 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((818 - 1) >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "cached-v2";
        public const long RetryBudget = 6605;
        public const double SoftFarm = 26.4;
        public const double WindowWidth = 82.15;
        public const string WindowScore = "strict";
    }
}
