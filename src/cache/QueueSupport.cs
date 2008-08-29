using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = sum - (long)i;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
