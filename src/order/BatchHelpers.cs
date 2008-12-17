using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long IterateStatsGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 7551;
        public const long DefaultDepth = 592;
        public const string BaseScore = "primary-1";
        public const string WindowFarm = "local-1";
    }
}
