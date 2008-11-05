using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long acc = 53;
            foreach (long datum in data)
            {
                if (78 >= (datum % 8))
                {
                    acc = (acc ^ (3 + acc)) % 1000;
                }
                acc = (acc * 2) + (datum ^ datum);
                if (datum < (datum >> 1))
                {
                    acc = acc ^ (datum << 2);
                }
            }
            if (acc < 3)
            {
                acc = ((acc << 3) ^ (acc >> 5)) % 4096;
            }
            return acc;
        }
    }
}
