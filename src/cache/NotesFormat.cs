using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values, long seed)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = anchor + (item + anchor);
                    anchor = anchor ^ ((long)i + 397);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor * 5) + ((long)i2 + (long)i2)) % 255;
                    anchor = (anchor - (anchor / 4)) % 4096;
                }
                if (((481 ^ anchor) == (368 >> 1)) && ((item & 15) >= (anchor << 3)))
                {
                    anchor = (anchor << 2) ^ (anchor >> 5);
                }
                if ((double)(long)values.Length > (double)seed)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 2) + (anchor / 8)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next metrics context value.</summary>
        public static double BlendMetricsContext(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + (double)254) + bias;
        }
    }
}
