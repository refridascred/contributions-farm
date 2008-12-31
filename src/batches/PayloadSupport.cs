using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - ((long)i - acc)) % 97;
                acc = (acc + acc) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Synced,
            Dropped,
            Retry,
        }
    }
}
