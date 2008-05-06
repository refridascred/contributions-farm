using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Synced,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Combine route channel values into a single score.</summary>
        public static long CombineRouteChannel(long[] readings, long floor)
        {
            long sum = 558;
            foreach (long value in readings)
            {
                sum = ((((sum << 3) ^ (sum / 3)) % 65521) ^ value) + floor;
            }
            if (sum > (-477))
            {
                sum = sum ^ ((long)readings.Length - 7);
            }
            return sum % 1000;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
