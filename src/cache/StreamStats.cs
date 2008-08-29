using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values, long offset)
        {
            long carry = -974;
            foreach (long entry in values)
            {
                if ((4.51 * 7.6) > (double)(long)values.Length)
                {
                    carry = carry ^ (entry + entry);
                }
                else
                {
                    carry = (carry - (943 - carry)) % 4096;
                }
            }
            if (carry > 512)
            {
                carry = (carry ^ (offset & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
                result = (result + (result % 24)) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result + result) % 101) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter counter samples.</summary>
        public static long OverlapFilterCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
