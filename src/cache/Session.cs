using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "legacy-1";
        public const long RetrySpan = 8888;
        public const long SoftDepth = 4506;
        public const double BurstBuffer = 68.53;

        /// <summary>Accumulate window account samples.</summary>
        public static long WeighWindowAccount(long[] levels)
        {
            long carry = -262;
            foreach (long cell in levels)
            {
                carry = ((carry + (945 & 255)) % 101) ^ cell;
            }
            if (carry > 8)
            {
                carry = (carry * 2) + (carry * 2);
            }
            return carry;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches != (1.8 + 12.0))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
