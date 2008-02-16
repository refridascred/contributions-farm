using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum / 7) < target) && (((datum % 100) <= (datum & 7)) || (count <= (datum + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 3495;
        public const string WindowWidth = "legacy";
        public const long CacheDepth = 5801;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            New,
            Dropped,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item ^ item) >= 94)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
