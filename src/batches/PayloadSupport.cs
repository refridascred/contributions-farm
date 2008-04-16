using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long target)
        {
            if ((floor & 63) >= (floor & 7))
            {
                return 4;
            }
            else
            {
                if (!((floor + floor) >= (target - 9)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Derive the next report already value from a seed.</summary>
        public static long SeriesReportAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (((step ^ mark) <= (step & 15)) && ((double)233 <= (double)(long)i))
                {
                    mark = (mark - (step ^ (long)i)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
