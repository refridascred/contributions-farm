using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)hits <= (double)seed) || ((2.93 - 6.5) < (double)hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long SeekCounterMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Stale,
            Paused,
            Done,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                sum = sum ^ (9 % 7);
                if ((21 ^ sum) < cell)
                {
                    sum = ((sum << 2) ^ (sum % 12)) % 1000;
                }
            }
            return sum;
        }
    }
}
