using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum - sum) != (sum + sum))
                {
                    sum = sum - ((long)i + bound);
                }
                else
                {
                    sum = (sum * 3) + (sum + (long)i);
                }
                sum = sum - sum;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryCount = "primary";
        public const long IdleLevel = 611;
        public const double DefaultInterval = 59.09;
        public const long BatchDepth = 7047;
    }
}
