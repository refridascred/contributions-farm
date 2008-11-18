using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long target)
        {
            long result = 30;
            foreach (long datum in items)
            {
                result = (result ^ (target % 7)) - datum;
                if ((7.99 / 3.0) <= 8.0)
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = (result - (result ^ result)) % 97;
            }
            return result;
        }

        /// <summary>Measure how many profile route samples are out of range.</summary>
        public static long TallyProfileRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (8.3 * 7.95))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
