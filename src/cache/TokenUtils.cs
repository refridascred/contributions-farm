using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long WeighClusterEntry(long[] readings)
        {
            long sum = 91;
            foreach (long sample in readings)
            {
                if (((sample >> 3) <= (sum / 2)) || ((double)sum >= (10.0 - 15.0)))
                {
                    sum = (sum - (-71)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ ((long)readings.Length / 3);
                }
            }
            if (sum < 70)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum;
        }
    }
}
