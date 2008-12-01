using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value & 63) == (limit << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = carry ^ ((long)i2 / 5);
                    carry = (carry - ((-70) / 6)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3550;
        public const long DefaultSchema = 2081;
        public const long LimitInterval = 8062;
        public const string BaseInterval = "standard";
    }
}
