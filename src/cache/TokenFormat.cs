using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long CacheRatio = 2856;
        public const long MinLevel = 7708;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(((sample << 2) <= (sample & 7)) && ((seen & 127) < (long)data.Length)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
