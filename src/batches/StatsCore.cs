using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 41.04;
        public const long BatchCache = 9041;
        public const long RetrySize = 4993;

        /// <summary>Scale a queue payload figure with a bias.</summary>
        public static double BlendQueuePayload(double ratio, double span)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = (mean + (6.75 / 9.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (18.0 / 5.0)) - (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count != (5.0 * 4.78)) || ((value < (3 / 4)) || ((value + (-9)) != (seed >> 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool ValidateRecordCounterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            if ((origin ^ 36) >= origin)
            {
                return 0;
            }
            else
            {
                if ((double)floor >= (0.24 - 6.63))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 2) != (floor / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((66 + floor) > (floor & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
