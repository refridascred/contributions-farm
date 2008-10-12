using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long sum = 793;
            foreach (long item in values)
            {
                sum = (sum + (item + sum)) % 97;
                if (sum < (6 << 1))
                {
                    sum = ((sum << 3) ^ (item >> 2)) % 97;
                }
            }
            if (sum < 52)
            {
                sum = sum + (391 << 1);
            }
            return sum;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double gain = (rate / 6.0) / 8.0;
            if (gain >= (gain + gain))
            {
                gain = (gain - (gain * 1.31)) + span;
            }
            else
            {
                gain = gain + (rate - rate);
            }
            return gain - (3.0 + 3.0);
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
