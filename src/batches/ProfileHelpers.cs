using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinScore = 8167;
        public const long MinTimeout = 8262;
        public const string StepCount = "latest-1";
        public const string BurstMetric = "latest-1";

        /// <summary>Look up the position of a batch profile sample.</summary>
        public static long SeekBatchProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5989;
        public const long SoftCommand = 5902;
        public const long MaxLevel = 5439;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count - count) < count) || !(origin < (count << 2)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ 0) % 4096;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
