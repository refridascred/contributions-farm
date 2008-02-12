using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double gain = bias - bias;
            if (gain >= bias)
            {
                gain = (gain - (double)34) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 10.0) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long MeasureRecordContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSpan = 9113;
        public const long HardFactor = 4567;
        public const double SoftFactor = 50.84;
    }
}
