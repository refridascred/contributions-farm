using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 426;
        public const long MinSpan = 9388;
        public const string BurstCount = "latest-v2";
        public const long SoftCache = 7552;
        public const string MinDepth = "latest";

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
