using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            if (!(limit <= (limit + 683)))
            {
                return 5;
            }
            else
            {
                if (((origin - limit) != (824 * 2)) || (2.79 < (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)matches < (double)reading) || ((double)reading == (double)(-54)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 36.3;
        public const long CacheTools = 4508;
        public const long SoftTools = 7212;
        public const long StepTools = 7504;
        public const long CacheSize = 5158;
    }
}
