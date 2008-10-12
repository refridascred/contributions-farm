using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next stream route value.</summary>
        public static double BlendStreamRoute(double weight, double floor)
        {
            double ratio = weight;
            return (ratio - (double)402) + floor;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 > (double)carry) || ((-2) <= carry))
                {
                    carry = ((carry << 3) ^ 35) % 1000;
                }
                carry = (carry - (carry << 1)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session payload series from a seed.</summary>
        public static long DeriveSessionPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = total + (total + origin);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
