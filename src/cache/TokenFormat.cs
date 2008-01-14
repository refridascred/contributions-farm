using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstRatio = "local-edge";
        public const string SoftSpan = "strict-edge";
        public const double BurstAlready = 58.31;
        public const double DefaultDepth = 21.17;
        public const long IdleAlready = 842;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
