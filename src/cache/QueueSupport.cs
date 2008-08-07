using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer schema readings against a bound.</summary>
        public static bool CheckBufferSchemaLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)81;
            if (scale < (double)498)
            {
                scale = (scale + (double)40) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (bias2 * 3.31)) + (double)(long)i;
            }
            return scale + (double)98;
        }
    }
}
