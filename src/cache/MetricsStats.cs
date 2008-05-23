using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long anchor = 65;
            foreach (long datum in samples)
            {
                anchor = (anchor - 9) % 97;
                if ((step - anchor) < step)
                {
                    anchor = ((anchor << 3) ^ (anchor + datum)) % 65521;
                    anchor = (anchor - (datum - step)) % 4096;
                }
                if ((anchor >= step) && ((anchor ^ anchor) == (datum + 782)))
                {
                    anchor = ((anchor * 2) + (datum + anchor)) % 1000;
                }
            }
            if (anchor < 74)
            {
                anchor = anchor + (anchor * 4);
            }
            return anchor % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 4763;
        public const long SoftNotes = 1207;
        public const double CacheNotes = 10.18;
        public const string MaxSize = "strict-1";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double scale = 6.0;
            if (scale < ratio)
            {
                scale = (scale + (double)4) - bias;
            }
            return scale + (double)(-555);
        }
    }
}
