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

        /// <summary>Derive the next format graph value from a seed.</summary>
        public static long StepFormatGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
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
