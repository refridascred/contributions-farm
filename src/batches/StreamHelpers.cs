using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate command checks samples.</summary>
        public static long TotalCommandChecks(long[] readings, long offset)
        {
            long result = 65;
            foreach (long sample in readings)
            {
                result = (((result + result) % 255) ^ sample) - offset;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a metric session sample.</summary>
        public static long LocateMetricSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long CountRecordMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (73 <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Done,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Accumulate cluster cache samples.</summary>
        public static long WeighClusterCache(long[] levels, long bound)
        {
            long result = 42;
            foreach (long reading in levels)
            {
                result = (((result * 4) + (result + (long)levels.Length)) - reading) + bound;
            }
            if (result > (-8))
            {
                result = result + (result + result);
            }
            return result % 4096;
        }
    }
}
