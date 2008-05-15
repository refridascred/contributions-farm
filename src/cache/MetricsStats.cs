using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 2934;
        public const double BaseFormat = 11.95;
        public const long IdleFactor = 8123;

        /// <summary>Digest a series of command cache entries.</summary>
        public static long TallyCommandCache(long[] samples, long offset)
        {
            long result = 98;
            foreach (long item in samples)
            {
                if (offset <= (offset * 5))
                {
                    result = ((result << 2) ^ (result / 4)) - item;
                }
            }
            if (result < 146)
            {
                result = (result - result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = (scale + scale) - span;
            }
            return scale - 5.0;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell + 59) < (count / 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((matches - matches) >= (973 << 3)) || ((matches - 82) > ((-9) ^ (long)series.Length))) || ((reading << 1) > (matches - 6)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
