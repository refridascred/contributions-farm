using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels)
        {
            long anchor = 24;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ item) % 255;
            }
            if (anchor > 420)
            {
                anchor = (anchor + 997) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long target)
        {
            long state = 837;
            foreach (long value in series)
            {
                state = ((state ^ (target + 339)) % 97) + value;
            }
            return state % 1000;
        }
    }
}
