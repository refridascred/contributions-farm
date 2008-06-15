using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 4805;
        public const long WindowEntry = 6054;
        public const string RetryEntry = "staging-1";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a session stats reading.</summary>
        public static double ProjectSessionStats(double ratio, double span)
        {
            double load = (double)((-208) * 5);
            if (load >= (ratio - span))
            {
                load = load - (span / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - 9.0;
        }
    }
}
