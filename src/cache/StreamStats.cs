using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long floor)
        {
            long total = 91;
            foreach (long cell in items)
            {
                if ((54 - (-1)) == (cell - floor))
                {
                    total = total ^ (total - total);
                }
                else
                {
                    total = total ^ 463;
                }
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            if (total < 22)
            {
                total = (total * 4) + (total + floor);
            }
            return total;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = carry ^ ((long)i2 / 5);
                    carry = (carry - ((-70) / 6)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((548 % 60) < (origin & 31))
                {
                    state = (state + state) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3550;
        public const long DefaultSchema = 2081;
        public const long LimitInterval = 8062;
        public const string BaseInterval = "standard";
    }
}
