using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8169;
        public const double MinTimeout = 98.48;
        public const long CacheInterval = 4703;
        public const double IdleDepth = 9.03;

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double drift = (double)(2 << 2);
            if (drift < 7.05)
            {
                drift = (drift + (5.1 + 12.0)) - offset;
            }
            return drift + (drift - weight);
        }
    }
}
