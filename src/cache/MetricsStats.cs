using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev - 170) < (2 + prev))
            {
                return 0;
            }
            else
            {
                if (!((offset & 127) > (offset + 910)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((24 - bound) == (2 % 24))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5587;
        public const string BaseStats = "open-1";
        public const long HardStats = 1447;
    }
}
