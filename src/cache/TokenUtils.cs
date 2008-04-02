using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit checks counter readings against a rule.</summary>
        public static long MeasureChecksCounterHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((7.65 + 9.0) <= (13.0 * 6.7)))
                {
                    matches = ((matches + 2) - item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
