using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(offset <= (offset % 2)))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double mean = floor;
            if (mean <= (floor + floor))
            {
                mean = (mean - floor) + bias;
            }
            else
            {
                mean = mean - (double)(-2);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Retry,
            Active,
            Synced,
            New,
        }
    }
}
