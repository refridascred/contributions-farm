using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long result = -738;
            foreach (long sample in values)
            {
                result = (result - floor) % 65521;
                if (((-42) < (8 - sample)) || ((result & 1) < (floor + sample)))
                {
                    result = (result << 2) ^ (result + 978);
                }
                if ((2 < (result / 6)) || ((result / 2) > (sample / 7)))
                {
                    result = (result << 2) ^ (floor << 2);
                }
                else
                {
                    result = (result * 4) + result;
                }
            }
            return result;
        }
    }
}
