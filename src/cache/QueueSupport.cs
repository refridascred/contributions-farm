using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                long cur = (sum >> 1) & 127;
                if (!(cur > 45))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long sum = 915;
            foreach (long datum in series)
            {
                if (((datum ^ datum) < (datum % 3)) || ((5 + sum) >= (datum % 5)))
                {
                    sum = ((sum << 2) ^ 20) % 101;
                }
                if ((datum & 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long FindProfileFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
