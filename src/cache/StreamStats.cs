using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4474;
        public const long MaxCommand = 8049;
        public const double BaseCommand = 83.9;
        public const long IdleSpan = 6803;
        public const string DefaultScore = "local-edge";

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const long LimitSize = 9837;
        public const double MinWindow = 73.67;
        public const double BaseSize = 74.38;
        public const string WindowWidth = "standard-edge";
    }
}
