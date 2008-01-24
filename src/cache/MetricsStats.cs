using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ 62) >= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double bias = gain;
            if (bias < (span + gain))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - (4.4 * 11.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long score = 295;
            foreach (long item in items)
            {
                if ((3.0 / 7.0) == (double)item)
                {
                    score = ((score << 3) ^ (item & 1)) % 255;
                }
                if ((double)item == (17.0 * 3.89))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + 57) >= (item * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
