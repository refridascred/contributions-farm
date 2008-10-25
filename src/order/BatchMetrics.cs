using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((68 >> 3) < (count & 63)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 3) >= (limit / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools batch samples are out of range.</summary>
        public static long TallyToolsBatchGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((origin - 352) > (seen & 255))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long TallyFarmMetricGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)limit <= (1.0 - 3.63))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
