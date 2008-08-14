using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster entry samples are out of range.</summary>
        public static long TallyClusterEntryOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= 1.0)
                {
                    matches = ((matches + 1) + datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long TallyFarmBufferHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((9.29 <= (double)floor) || ((floor << 3) == (matches & 3))) && ((((long)data.Length - reading) == (matches ^ floor)) && ((floor * 3) != (matches << 2))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Active,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
