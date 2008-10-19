using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items, long seed)
        {
            long acc = 720;
            foreach (long entry in items)
            {
                if ((acc + (-7)) > ((-10) & 15))
                {
                    acc = (acc ^ (acc >> 1)) ^ entry;
                }
            }
            if (acc > 61)
            {
                acc = ((acc * 2) + (seed & 31)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Find the first command checks entry that matches the target.</summary>
        public static long LocateCommandChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 5109;
        public const long CacheChannel = 4284;
        public const double BurstChannel = 39.52;
        public const long BaseChannel = 3064;
    }
}
