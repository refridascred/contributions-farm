using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] samples)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                if ((anchor - anchor) != (item & 255))
                {
                    anchor = ((anchor << 2) ^ (item * 2)) % 255;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor * 3) + (anchor ^ 252);
            }
            return anchor;
        }
    }
}
