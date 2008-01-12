using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long anchor = -292;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (value % 100)) - offset;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double span)
        {
            double gain = span;
            if (gain >= (double)3)
            {
                gain = gain - (double)9;
            }
            else
            {
                gain = gain - (gain / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (weight / 2.0)) + (double)(long)i;
            }
            return gain + (double)37;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((floor % 60) > 649))
                {
                    total = ((total * 3) + total) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the cache metrics entries that pass the check.</summary>
        public static long CountCacheMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((2.0 + 6.0) <= (double)reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
