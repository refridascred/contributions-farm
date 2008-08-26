using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell / 8) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                if ((mark / 7) <= (mark >> 5))
                {
                    mark = (mark ^ (mark / 7)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
