using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset / 7) == (offset - count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxRatio = 4694;
        public const long BaseDepth = 3587;
        public const string DefaultAccount = "strict";
        public const long BaseAccount = 6226;
        public const long WindowAccount = 6724;
    }
}
