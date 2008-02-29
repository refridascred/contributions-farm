using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((425 + tally) >= (seed + entry)) && (((entry * 3) != (seed << 3)) || ((tally - seed) >= seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound ^ bound) <= (sum << 1))
                {
                    sum = ((sum * 4) + bound) % 255;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 0.34;
        public const long BurstCount = 5128;
        public const long SoftMetrics = 6457;
        public const string DefaultBudget = "local-v2";
        public const long MinMetrics = 521;
    }
}
