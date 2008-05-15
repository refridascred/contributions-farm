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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((bound * 5) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
