using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftLevel = 1.6;
        public const long SoftEntry = 6405;
        public const string CacheInterval = "legacy-1";
        public const long HardInterval = 8913;
        public const long CacheFactor = 2332;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
