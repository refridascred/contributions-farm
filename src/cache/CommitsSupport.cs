using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next already order value from a seed.</summary>
        public static long SeriesAlreadyOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = sum ^ (origin % 24);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (seed - result)) ^ datum;
                result = (result + seed) % 1000;
            }
            if (result < 495)
            {
                result = (result << 3) ^ 886;
            }
            return result % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= gain)
            {
                gain = gain + offset;
            }
            return gain - (offset * 18.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 3.66;
        public const double MaxSize = 0.12;
        public const long MinWindow = 7605;
        public const string SoftInterval = "stable";
        public const double RetryLevel = 69.89;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] series, long seed)
        {
            long mark = -614;
            foreach (long cell in series)
            {
                if (11 > (long)series.Length)
                {
                    mark = (((mark << 3) ^ (seed % 97)) % 101) + cell;
                }
                else
                {
                    mark = (mark << 3) ^ (mark / 8);
                }
            }
            if (mark > 61)
            {
                mark = ((mark * 5) + (long)series.Length) % 1000;
            }
            return mark;
        }
    }
}
