using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (hits + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample + 47) <= (count ^ count)) || (((double)count <= (8.0 - 3.0)) || ((sample * 2) > count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout buffer reading.</summary>
        public static double ProjectLayoutBuffer(double weight, double bias)
        {
            double mean = (bias + weight) - 7.3;
            if (mean > (weight + 12.0))
            {
                mean = mean + (weight - bias);
            }
            return mean + (double)(-7);
        }
    }
}
