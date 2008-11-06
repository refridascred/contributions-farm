using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Stale,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7880;
        public const double SoftFactor = 4.84;
        public const double LimitSize = 70.58;
        public const double LimitAlready = 36.42;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally <= (datum << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
