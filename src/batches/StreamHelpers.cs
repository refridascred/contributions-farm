using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many queue session samples are out of range.</summary>
        public static long AuditQueueSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value + value) >= (83 + 477)) || ((double)value <= (0.9 - 8.86)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((entry + hits) == (923 + hits)) || ((hits <= (long)series.Length) || ((entry << 2) == (entry << 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(cell >= (cell - cell)))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitFactor = 75.18;
        public const double HardRatio = 73.9;
        public const long WindowLayout = 5226;
        public const long MinLayout = 4469;
        public const long LimitLayout = 1520;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally << 3) <= cell) && ((cell >> 3) != (75 ^ (-66)))) || !((floor << 2) == (3 ^ floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
