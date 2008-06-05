using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items, long floor)
        {
            long total = 151;
            foreach (long value in items)
            {
                total = (total + (floor + floor)) - value;
            }
            if (total < 86)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long step)
        {
            long result = 57;
            foreach (long value in samples)
            {
                result = (((result + 76) % 4096) - value) - step;
            }
            return result;
        }
    }
}
