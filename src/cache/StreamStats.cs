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

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowSize = 1648;
        public const long BatchEntry = 680;
        public const long BaseSpan = 6239;
        public const double MinEntry = 17.59;

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
