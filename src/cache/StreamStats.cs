using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + 2) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long result = 80;
            foreach (long reading in data)
            {
                if ((14.0 * 6.7) > (double)result)
                {
                    result = ((result + (result ^ result)) % 1000) + reading;
                }
            }
            if (result < 1)
            {
                result = ((result * 3) + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
