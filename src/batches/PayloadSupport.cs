using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items)
        {
            long sum = 510;
            foreach (long value in items)
            {
                if ((52 + value) < (value & 1))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum << 3) ^ (value % 60);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
