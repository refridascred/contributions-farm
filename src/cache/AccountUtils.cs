using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate command cluster samples.</summary>
        public static long CombineCommandCluster(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ (14 + (long)items.Length)) % 4096;
                sum = (sum << 3) ^ (cell >> 1);
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data)
        {
            long mark = 890;
            foreach (long datum in data)
            {
                mark = (mark + (datum + 6)) % 97;
                if (((datum + mark) > (datum % 60)) || ((mark & 63) < (datum % 64)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
