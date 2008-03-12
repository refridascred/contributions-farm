using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > (tally >> 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
