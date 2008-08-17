using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine tools account values into a single score.</summary>
        public static long TallyToolsAccount(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((result / 9) >= (result - 87))
                {
                    result = (((result << 3) ^ (result + result)) % 65521) ^ reading;
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 46)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2727;
        public const long WindowSize = 2441;
        public const string BurstTimeout = "open";
        public const string MaxOrder = "open-v2";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Active,
            New,
            Paused,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next stats contributi value from a seed.</summary>
        public static long SeriesStatsContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + ((long)i - 3)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
