using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long limit)
        {
            long anchor = -84;
            foreach (long cell in data)
            {
                if (!((1 ^ limit) <= (limit * 5)))
                {
                    anchor = (anchor + (cell % 12)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry == (14.0 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
