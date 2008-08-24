using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 549;
        public const string BatchAccount = "local-v2";
        public const long WindowFactor = 7542;
        public const double RetryCount = 63.04;
        public const long MinAccount = 8408;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + item) > tally) || (((limit - limit) < (18 - limit)) && (tally >= (tally << 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((bound << 1) < 5)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
