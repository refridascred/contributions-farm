using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if (((result << 1) > item) || ((double)result <= 6.2))
                {
                    result = (result - (item & 63)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Done,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double scale, double floor)
        {
            double bias = 9.96;
            if (bias <= 1.27)
            {
                bias = ((bias + (3.45 / 6.0)) - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + 1.82;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the farm stream entries that pass the check.</summary>
        public static long MeasureFarmStreamGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((8 << 1) >= (floor & 1))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
