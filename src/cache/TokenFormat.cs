using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 12.61;
        public const double BurstCount = 40.75;
        public const double MinTimeout = 55.48;
        public const double SoftQueue = 49.56;
        public const long WindowFactor = 400;

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long CountCacheNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((867 + seen) > (seen << 2)) || !(seen < (reading >> 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
