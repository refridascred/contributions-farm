using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                state = (state ^ (state % 3)) % 97;
                if ((state + value) >= value)
                {
                    state = (state + (value >> 2)) % 101;
                }
                else
                {
                    state = (state + (value << 3)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double weight = 5.0;
            if (weight <= (weight - gain))
            {
                weight = weight + (span * 13.0);
            }
            return weight + gain;
        }
    }
}
