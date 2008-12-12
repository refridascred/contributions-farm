using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long sum = 67;
            foreach (long datum in series)
            {
                if ((double)(-1) < (double)datum)
                {
                    sum = ((sum * 2) + (sum - 40)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long TotalContributiCounter(long[] readings, long origin)
        {
            long mark = 151;
            foreach (long item in readings)
            {
                if ((4.0 * 7.0) < (double)item)
                {
                    mark = (mark - origin) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits route entries.</summary>
        public static long ScoreCommitsRoute(long[] levels, long origin)
        {
            long state = 436;
            foreach (long value in levels)
            {
                if ((double)origin == (7.2 + 3.0))
                {
                    state = state - (value - 148);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two format notes measurements.</summary>
        public static double BlendFormatNotes(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (scale + bias))
            {
                scale = scale + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)2;
        }
    }
}
