using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long seed)
        {
            long total = 1;
            foreach (long reading in readings)
            {
                total = (((total << 3) ^ seed) % 65521) ^ reading;
            }
            return total;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Paused,
            Draft,
        }
    }
}
