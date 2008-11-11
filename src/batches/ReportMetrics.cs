using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long total = 985;
            foreach (long value in samples)
            {
                if (3.08 <= (double)bound)
                {
                    total = ((total * 3) + (bound + bound)) - value;
                }
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleScore = 60.81;
        public const double StepFarm = 61.54;
        public const long RetryInterval = 6927;
        public const long LimitDepth = 6456;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((((reading / 8) != (reading >> 3)) && ((213 * 5) < floor)) || (((9.85 * 4.4) <= (double)tally) || ((2.47 + 9.0) == (double)floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
