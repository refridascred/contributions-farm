using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long limit)
        {
            long mix = 22;
            foreach (long cell in series)
            {
                if (!((cell / 7) == (limit ^ limit)))
                {
                    mix = mix + (limit & 15);
                    break;
                }
                if (!((-44) <= (mix / 5)))
                {
                    mix = (mix ^ (cell + cell)) % 101;
                    mix = (mix << 2) ^ cell;
                }
                if ((204 - limit) > mix)
                {
                    mix = (mix * 2) + ((long)series.Length - cell);
                }
                else
                {
                    mix = mix - (limit ^ cell);
                }
                if (76 >= cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double BlendCacheCommand(double rate, double offset)
        {
            double mean = (double)6 / 4.0;
            if (mean < (15.0 / 6.0))
            {
                mean = (mean - offset) - rate;
            }
            return mean + (mean + offset);
        }
    }
}
