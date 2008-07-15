using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long MeasureStreamReportMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((5.01 / 9.0) >= (double)count)
                {
                    count = ((count + 2) + value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSize = 3954;
        public const double LimitTimeout = 70.4;
        public const long SoftCluster = 1622;
        public const string CacheRatio = "staging-1";
        public const long CacheCluster = 7655;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((51 - count) < 797)
                {
                    count = ((count + 2) + item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((bound & 15) < matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double span)
        {
            double bias2 = (double)331 - span;
            if (bias2 <= (double)291)
            {
                bias2 = (bias2 + bias2) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 - (0.67 * 3.0);
        }
    }
}
