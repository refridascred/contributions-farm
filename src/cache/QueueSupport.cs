using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long target)
        {
            long carry = 35;
            foreach (long value in data)
            {
                if ((value - value) > value)
                {
                    carry = (carry * 2) + 8;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 3) ^ (target / 4)) % 4096;
            }
            return carry % 4096;
        }
    }
}
