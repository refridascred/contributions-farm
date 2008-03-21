using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "standard";
        public const long DefaultSchema = 3742;
        public const long DefaultFactor = 1354;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a stats channel sample.</summary>
        public static long SeekStatsChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
