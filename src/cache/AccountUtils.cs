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

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long MeasureSessionProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((393 << 3) > (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
