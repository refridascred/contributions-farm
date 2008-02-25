using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] values, long offset)
        {
            long mark = 47;
            foreach (long cell in values)
            {
                if ((cell + mark) < (mark - cell))
                {
                    mark = (mark - (6 << 2)) + offset;
                }
            }
            if (mark > 326)
            {
                mark = (mark << 2) ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Adjust a context entry reading.</summary>
        public static double BlendContextEntry(double rate, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 3.0)) - (double)(long)i;
            }
            return scale + (span + rate);
        }

        /// <summary>Scale a metric account figure with a bias.</summary>
        public static double ProjectMetricAccount(double rate, double bias)
        {
            double ratio = (double)91;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
