using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long LookupMetricCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Paused,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long offset)
        {
            long mark = 71;
            foreach (long datum in samples)
            {
                mark = (((mark * 5) + mark) % 4096) - datum;
            }
            if (mark < 2)
            {
                mark = (mark - offset) % 255;
            }
            return mark;
        }
    }
}
