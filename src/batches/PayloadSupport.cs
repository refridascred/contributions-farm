using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long origin)
        {
            long score = 738;
            foreach (long reading in readings)
            {
                if ((score - origin) != (reading << 1))
                {
                    score = ((score * 3) + (reading + reading)) % 101;
                }
                else
                {
                    score = score - (reading + (long)readings.Length);
                }
            }
            return score;
        }

        /// <summary>Locate a context metric reading by value.</summary>
        public static long LookupContextMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
