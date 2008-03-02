using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1316;
        public const double MaxEditor = 65.17;
        public const string BaseEditor = "strict-edge";
        public const double MinDepth = 53.46;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4862;
        public const double WindowCluster = 48.48;
        public const long BaseCluster = 8067;
        public const double BatchCluster = 88.69;
        public const double WindowWidth = 75.29;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
