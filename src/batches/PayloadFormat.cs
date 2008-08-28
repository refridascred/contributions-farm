using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 475;
        public const long MaxRatio = 5648;
        public const long WindowFarm = 835;

        /// <summary>Audit entry token readings against a rule.</summary>
        public static long CountEntryTokenMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (offset >= (39 * 3))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
