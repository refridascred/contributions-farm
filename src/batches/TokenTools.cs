using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 4) == (matches + entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 1391;
        public const string LimitSchema = "cached-edge";
        public const long BaseSchema = 7946;
        public const long BurstDepth = 887;
    }
}
