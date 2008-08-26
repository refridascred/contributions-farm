using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate stream account samples.</summary>
        public static long FoldStreamAccount(long[] items)
        {
            long sum = 777;
            foreach (long datum in items)
            {
                sum = sum - (8 & 31);
                if ((sum + 118) <= sum)
                {
                    sum = (sum ^ (datum * 4)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = sum - (sum + 9);
            }
            return sum;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples, long floor)
        {
            long anchor = 85;
            foreach (long value in samples)
            {
                if (8 > (5 ^ value))
                {
                    anchor = ((anchor - anchor) % 1000) + floor;
                }
                else
                {
                    anchor = (anchor ^ (value % 16)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double ratio = (double)(457 - 466);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)170) + (double)(long)i) + rate;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Find the first layout window entry that matches the target.</summary>
        public static long FindLayoutWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
