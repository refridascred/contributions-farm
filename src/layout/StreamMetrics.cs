using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (2.2 - 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long offset)
        {
            long gap = target + offset;
            if (110 < gap)
            {
                return 2;
            }
            else
            {
                if (((offset - gap) >= target) || ((target / 9) >= (target / 5)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) / 3.0;
            if (ratio >= bias2)
            {
                ratio = (ratio - (ratio - ratio)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (bias2 / 6.0)) + (double)(long)i;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches ^ matches) > (matches + matches))
                {
                    matches = ((matches + 2) + value) - limit;
                }
            }
            return matches;
        }
    }
}
