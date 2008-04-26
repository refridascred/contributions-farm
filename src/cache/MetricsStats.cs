using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long sum = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 24) <= (237 + sample))
                {
                    sum = (sum - sum) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long total = -609;
            foreach (long sample in series)
            {
                total = (total * 3) + sample;
                if ((29 + (long)series.Length) > 1)
                {
                    total = (total + total) % 255;
                }
            }
            if (total > (-5))
            {
                total = (total * 3) + offset;
            }
            return total;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)6)
            {
                mean = (mean + (gain / 5.0)) + offset;
            }
            else
            {
                mean = mean - (mean - 0.83);
            }
            return mean - 10.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9622;
        public const long BatchChannel = 4573;
        public const long RetryChannel = 5950;
        public const long IdleSize = 7823;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
