using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first batch token entry that matches the target.</summary>
        public static long FindBatchTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Blend two layout graph measurements.</summary>
        public static double SmoothLayoutGraph(double rate, double offset)
        {
            double rate2 = (9.0 + 2.1) - (double)70;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (offset - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - 5.1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
