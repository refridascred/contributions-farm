using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long RankContextSchema(long bound, long bound2)
        {
            if ((double)bound2 >= (3.0 - 9.97))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= (9.5 + 8.74)) && ((double)bound2 != (1.3 + 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 8495;
        public const long DefaultCluster = 8997;
        public const long BaseCluster = 1065;
        public const long StepCluster = 187;
        public const long IdleFactor = 16;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry % 10) >= (entry / 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Queued,
            Retry,
            Draft,
            New,
        }
    }
}
