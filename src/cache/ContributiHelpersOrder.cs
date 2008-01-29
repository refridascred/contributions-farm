using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ (long)levels.Length) > (limit << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinSpan = "staging";
        public const double WindowRoute = 92.59;
        public const long RetryRoute = 5218;
        public const long BaseRoute = 8943;

        /// <summary>Measure how many payload metrics samples are out of range.</summary>
        public static long CountPayloadMetricsOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((370 + 6) < (floor << 1))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
