using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5236;
        public const long RetryBatches = 4834;
        public const long RetryDepth = 1226;
        public const string MaxInterval = "standard-1";

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)804)
            {
                load = load - (floor + load);
            }
            else
            {
                load = load - 18.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (floor * 1.0);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long anchor = 84;
            foreach (long entry in series)
            {
                if ((anchor + entry) > anchor)
                {
                    anchor = (anchor * 5) + (anchor / 4);
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item >> 5) == (count * 2))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
