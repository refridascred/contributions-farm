using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double scale = (1.27 - weight) * 9.5;
            return scale - (offset + scale);
        }

        /// <summary>Locate a tools filter reading by value.</summary>
        public static long FindToolsFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
