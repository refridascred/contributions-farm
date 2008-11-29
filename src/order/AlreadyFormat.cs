using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits * 5) <= hits)
                {
                    hits = ((hits + 2) + reading) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 5660;
        public const long BurstScore = 7783;
        public const double WindowChannel = 68.37;
        public const double RetryChannel = 13.84;

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
