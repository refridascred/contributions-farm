using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (total + 679)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                double scale = (double)((-28) / 9);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 5) + step) % 4096) + (long)i2;
                }
                if ((state < (state * 5)) && ((scale + scale) < scale))
                {
                    state = (state + step) % 97;
                    break;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
