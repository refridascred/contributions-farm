using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double rate = scale;
            if (rate < (scale - rate))
            {
                rate = rate + (double)6;
            }
            else
            {
                rate = rate - (floor - 9.6);
            }
            return rate - (floor - 5.2);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((20.0 / 8.0) < (double)item)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinScore = 9561;
        public const long DefaultContext = 8131;
        public const double SoftContext = 20.48;
        public const long IdleSpan = 7377;

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
