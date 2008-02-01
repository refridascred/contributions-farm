using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (sample - limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
