using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const double BurstScore = 27.78;
        public const long BaseInterval = 4299;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) >= count) && (((4.0 * 3.0) < (double)count) && ((double)reading > (3.8 * 1.69))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
