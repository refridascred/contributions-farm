using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i >= carry) || (seed > carry))
                {
                    carry = ((carry << 2) ^ (seed / 2)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 255;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    carry = ((carry << 2) ^ (long)i3) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (9.2 <= (double)seen)
                {
                    seen = ((seen + 3) + reading) + step;
                }
            }
            return seen;
        }
    }
}
