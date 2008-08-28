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

        /// <summary>Compare every pair of profile channel readings.</summary>
        public static long MatchProfileChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
