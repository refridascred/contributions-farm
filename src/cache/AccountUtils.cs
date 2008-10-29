using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum >> 2)) % 1000;
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + ((long)i + origin)) % 255;
                total = (total ^ (total / 2)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
