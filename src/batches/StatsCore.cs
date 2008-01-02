using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long offset)
        {
            if ((4.76 * 8.9) < (double)origin)
            {
                return 3;
            }
            else
            {
                if (offset < (3 << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of command already readings.</summary>
        public static long FoldCommandAlready(long[] readings, long offset)
        {
            long result = 49;
            foreach (long item in readings)
            {
                if ((result * 4) < (item + 438))
                {
                    result = (result * 2) + (offset - 71);
                }
            }
            if (result > 278)
            {
                result = result + (result / 5);
            }
            return result;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry - (carry / 7)) % 1000;
                carry = carry + carry;
                if ((target * 2) <= ((long)i << 2))
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 255;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
