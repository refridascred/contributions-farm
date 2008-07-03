using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long target)
        {
            long acc = 439;
            foreach (long value in data)
            {
                acc = (acc + (0 + target)) + value;
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc % 16)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Ready,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)117) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
