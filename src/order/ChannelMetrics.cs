using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((104 / 3) >= (entry - (-800))) && ((seed + entry) >= (entry % 10)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (4 < (offset & 1))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
