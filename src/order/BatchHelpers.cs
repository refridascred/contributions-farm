using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 95.22;
        public const long BurstCache = 5324;
        public const long HardCache = 7056;
        public const long IdleCache = 1484;
        public const long MaxWidth = 3606;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series, long origin)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = (((anchor * 3) + (anchor >> 3)) + datum) + origin;
            }
            if (anchor > 64)
            {
                anchor = (anchor + (anchor % 8)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
