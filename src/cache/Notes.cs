using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
