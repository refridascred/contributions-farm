using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long anchor = 44;
            foreach (long item in values)
            {
                anchor = (anchor * 4) + (item * 3);
                anchor = (anchor << 2) ^ (anchor - anchor);
                if ((anchor >> 1) < (anchor + item))
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 8)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 97;
            }
            return anchor;
        }
    }
}
