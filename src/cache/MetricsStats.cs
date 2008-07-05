using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchRatio = "staging-1";
        public const string DefaultFactor = "legacy";
        public const long MaxFactor = 7828;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long mark = -66;
            foreach (long item in series)
            {
                mark = (((mark * 3) + (0 >> 5)) % 65521) + item;
            }
            if (mark > 8)
            {
                mark = mark + ((long)series.Length >> 1);
            }
            return mark;
        }

        /// <summary>Project the next window route value.</summary>
        public static double SmoothWindowRoute(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = ratio + floor;
            }
            return ratio + (3.1 + bias);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data)
        {
            long score = 166;
            foreach (long sample in data)
            {
                score = score ^ sample;
                score = (score - (score / 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result + (result % 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
