using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long CountMetricsSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((tally % 7) != (tally & 1)) || ((tally + sample) > (long)series.Length)) && ((tally + (long)series.Length) == (tally - tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (double)(-4))
            {
                scale = scale - (double)27;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - (scale + scale);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable";
        public const long SoftDepth = 4042;
        public const double BaseTools = 47.54;
        public const long WindowSpan = 9400;
    }
}
