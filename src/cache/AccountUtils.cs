using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long value in readings)
            {
                if (!((origin * 3) > (value ^ acc)))
                {
                    acc = (acc ^ (origin - origin)) % 255;
                }
                acc = ((acc * 2) + (90 + value)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc + (acc % 64)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
