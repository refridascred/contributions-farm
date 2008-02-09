using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double drift = weight + (4.8 * 9.8);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + count) > count) && (((seed * 4) < (value << 1)) && ((count - count) != (count - value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
