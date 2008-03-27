using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items, long bound)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                carry = ((carry ^ (bound * 4)) % 255) ^ cell;
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ seed) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
