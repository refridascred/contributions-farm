using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 4084;
        public const long IdleWindow = 4452;
        public const string HardWindow = "stable-edge";

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long limit)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                acc = (acc + (acc % 100)) % 101;
                if ((acc >> 1) == (limit << 3))
                {
                    acc = acc ^ (reading & 127);
                }
                if ((acc % 60) <= (limit % 64))
                {
                    acc = acc + (reading >> 2);
                }
                else
                {
                    acc = (acc * 3) + (167 - 11);
                }
            }
            return acc;
        }
    }
}
