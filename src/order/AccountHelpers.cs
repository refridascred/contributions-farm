using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double mean = (double)6 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + floor;
            }
            return mean + ratio;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)bound >= 6.7)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 19.67;
        public const long BatchReport = 8673;
        public const double SoftSize = 66.43;
        public const double LimitRatio = 7.65;
        public const string HardReport = "legacy-edge";

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
